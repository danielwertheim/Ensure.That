Framework "4.5.1"

Properties {
    $build_version = "2.0.0"
    $build_config = "Release"
    $builds_dir_path = "builds"
}

task Configure {
    $script:solution_name = "Ensure.That"
    $script:solution_dir_path = "..\src"
    $script:solution_path = "$solution_dir_path\$solution_name.sln"
    $script:project_name = "EnsureThat"
    $script:build_name = "$project_name-v$build_version-$build_config"
    $script:build_dir_path = "$builds_dir_path\$build_name"
    $script:tools_dir_path = "tools"
    $script:testrunner = "$tools_dir_path\xunit.runners.1.9.2\tools\xunit.console.clr4.exe"
    $script:nuget = "nuget.exe"
}

task Default -Depends Configure, InitTools, Clean, Build, Copy, Tests-UnitTest

task CI -Depends Default, Nuget-Pack

task InitTools {
    Exec { & $nuget restore "$tools_dir_path/packages.config" -o $tools_dir_path }
}

task Clean {
    Clean-Directory($build_dir_path)
}

task Build {
    Exec { & $nuget restore $solution_path }
    Exec { msbuild "$solution_path" /t:Clean /p:Configuration=$build_config /v:quiet }
    Exec { msbuild "$solution_path" /t:Build /p:Configuration=$build_config /v:quiet }
}

task Copy {
    CopyTo-Build($project_name)
}

task Tests-UnitTest {
    UnitTest-Project($project_name)
}

task NuGet-Pack {
    NuGet-Pack-Project $solution_name $build_dir_path
    NuGet-Pack-Project "$solution_name.Source" $solution_dir_path
}

Function UnitTest-Project($t) {
    Exec { & $testrunner "$solution_dir_path\tests\$t.UnitTests\bin\$build_config\$t.UnitTests.dll" }
}

Function NuGet-Pack-Project($t, $p) {
    Exec { & $nuget pack "$t.nuspec" -version $build_version -basepath $p -outputdirectory $build_dir_path }
}

Function EnsureClean-Directory($dir) {
    Clean-Directory($dir)
    Create-Directory($dir)
}

Function Clean-Directory($dir) {
	if (Test-Path -path $dir) {
        rmdir $dir -recurse -force
    }
}

Function Create-Directory($dir) {
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