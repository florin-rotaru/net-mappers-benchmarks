$cd = Get-Location
Push-Location $folder
dotnet run -c Release --path "$cd\BenchmarksResults"