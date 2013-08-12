Function OutPut ($v) {
  Write-Host $v -ForegroundColor Cyan
}

Function Install-Packages($basePath) {
  OutPut "Installing missing NuGet packages..."
  $c = 0
  Get-ChildItem $basePath -Filter "packages.config" -Recurse |
    ForEach-Object {
      OutPut "Installing packages for: '$($_.FullName)'"
      nuget i ""$($_.FullName)"" -o "$($basePath)\packages"
      $c += 1
    }
  OutPut "Processed $($c) package(s).config."
}

Install-Packages("src")