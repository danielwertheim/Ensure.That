Framework "4.5.1"

Properties {
    $solution_name = "Ensure.That"
    $solution_name_net35 = "Ensure.That-net35"
    $solution_dir_path = "..\src"
    $solution_path = "$solution_dir_path\$solution_name.sln"
    $solution_path_net35 = "$solution_dir_path\$solution_name_net35.sln"
    $project_name = "EnsureThat"
    $project_name_net35 = "EnsureThat-net35"
    $builds_dir_path = "builds"
    $build_version = "2.0.0"
    $build_config = "Release"
    $build_name = "${project_name}-v${build_version}-${build_config}"
    $build_dir_path = "${builds_dir_path}\${build_name}"
    $testrunner = "xunit.console.exe"
    $nuget = "nuget.exe"
    $binary_dir_path = $builds_dir_path + "\" + $build_name
}

task default -depends Clean, Build, Copy, Tests-UnitTest, Nuget-Pack

task Clean {
    Clean-Directory("$build_dir_path")
}

task Build {
    Exec { msbuild "$solution_path" /t:Clean /p:Configuration=$build_config /v:quiet }
    Exec { msbuild "$solution_path" /t:Build /p:Configuration=$build_config /v:quiet }
    Exec { msbuild "$solution_path_net35" /t:Clean /p:Configuration=$build_config /v:quiet }
    Exec { msbuild "$solution_path_net35" /t:Build /p:Configuration=$build_config /v:quiet }
}

task Copy {
    CopyTo-Build("$project_name")
}

task Tests-UnitTest {
    UnitTest-Project($project_name)
}

task NuGet-Pack {
    $resolved_path = Resolve-Path $binary_dir_path
    Write-Host $resolved_path
    NuGet-Pack-Project $solution_name $resolved_path
    NuGet-Pack-Project "$solution_name.Source" $solution_dir_path
}

Function UnitTest-Project($t) {
    & $testrunner "$solution_dir_path\tests\$t.UnitTests\bin\$build_config\$t.UnitTests.dll"
    & $testrunner "$solution_dir_path\tests\$t.UnitTests\bin35\$build_config\$t.UnitTests.dll"
}

Function NuGet-Pack-Project($t, $p) {
    & $nuget pack "$t.nuspec" -version $build_version -basepath $p -outputdirectory $builds_dir_path
}

Function EnsureClean-Directory($dir) {
    Clean-Directory($dir)
    Create-Directory($dir)
}

Function Clean-Directory($dir){
	if (Test-Path -path $dir) {
        rmdir $dir -recurse -force
    }
}

Function Create-Directory($dir){
	if (!(Test-Path -path $dir)) {
        new-item $dir -force -type directory
    }
}

Function CopyTo-Build($t) {
    $src = "$solution_dir_path\projects\$t\bin\$build_config\$t.*"
    $trg = "$build_dir_path\net40\$t"
    $src_net35 = "$solution_dir_path\projects\$t\bin35\$build_config\$t.*"
    $trg_net35 = "$build_dir_path\net35\$t"
    
    EnsureClean-Directory($trg)
    EnsureClean-Directory($trg_net35)
    
    CopyTo-Directory $src $trg
    CopyTo-Directory $src_net35 $trg_net35
}

Function CopyTo-Directory($src, $trg) {
    Copy-Item -Path $src -Include *.dll,*.xml -Destination $trg -Recurse -Container
}