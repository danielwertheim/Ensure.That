Framework "4.0"

Properties {
    $solution_name = "Ensure.That"
    $solution_dir_path = "..\src"
    $solution_path = "$solution_dir_path\$solution_name.sln"
    $project_name = "EnsureThat"
    $builds_dir_path = "builds"
    $build_version = "1.0.0"
    $build_config = "Release"
    $build_name = "${project_name}-v${build_version}-${build_config}"
    $build_dir_path = "${builds_dir_path}\${build_name}"
    $testrunner = "xunit.console.exe"
    $nuget = "nuget.exe"
}

task default -depends Clean, Build, Copy, Tests-UnitTest, Nuget-Pack

task Clean {
    Clean-Directory("$build_dir_path")
}

task Build {
    Exec { msbuild "$solution_path" /t:Clean /p:Configuration=$build_config /v:quiet }
    Exec { msbuild "$solution_path" /t:Build /p:Configuration=$build_config /v:quiet }
}

task Copy {
    CopyTo-Build("$project_name")
}

task Tests-UnitTest {
    UnitTest-Project($project_name)
}

task NuGet-Pack {
    NuGet-Pack-Project $solution_name $build_dir_path
    NuGet-Pack-Project "$solution_name.Source" $solution_dir_path
}

Function UnitTest-Project($t) {
    & $testrunner "$solution_dir_path\tests\$t.UnitTests\bin\$build_config\$t.UnitTests.dll"
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
    $trg = "$build_dir_path\$t"
    EnsureClean-Directory($trg)
    
    CopyTo-Directory $src $trg
}

Function CopyTo-Directory($src, $trg) {
    Copy-Item -Path $src -Include *.dll,*.xml -Destination $trg -Recurse -Container
}