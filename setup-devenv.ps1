Set-Alias nget nuget.exe

Function OutPut ($v) {
    Write-Host $v -ForegroundColor Cyan
}

Function Get-Package-Configs {
    return Get-ChildItem "src" -Filter "packages.config" -Recurse -File
}

Function Install-Packages {
    OutPut "Installing missing NuGet packages..."
    $c = 0
    Get-Package-Configs | ForEach-Object { 
        OutPut "Installing packages for: '$($_.FullName)'"
        nget i ""$($_.FullName)"" -o "src\packages"
        $c += 1
    }
    OutPut "Processed $($c) package(s).config."
}

Install-Packages