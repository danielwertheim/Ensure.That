Set-Alias nget nuget.exe

Function OutPut ($v) {
    Write-Host $v -ForegroundColor Cyan
}

Function Get-Package-Configs($basePath) {
    return Get-ChildItem $basePath -Filter "packages.config" -Recurse
}

Function Install-Packages($basePath) {
    OutPut "Installing missing NuGet packages..."
    $c = 0
    Get-Package-Configs($basePath) | ForEach-Object {
        OutPut "Installing packages for: '$($_.FullName)'"
        nget i ""$($_.FullName)"" -o "$($basePath)\packages"
        $c += 1
    }
    OutPut "Processed $($c) package(s).config."
}

Install-Packages("src")