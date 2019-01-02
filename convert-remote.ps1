$tempFolder = New-Guid
$ignore = New-Item $tempFolder.ToString() -ItemType Directory
$ignore = Set-Location $tempFolder.ToString()

$ignore = git clone https://github.com/ChristianEder/heic-2-jpg -q

$ignore = Set-Location heic-2-jpg

.\convert.ps1 "..\.."

$ignore = Set-Location ..
$ignore = Set-Location ..

$ignore = Remove-Item $tempFolder.ToString() -Recurse -Force
