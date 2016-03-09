Write-Host "Creating archive"
$mode = 'debug'
$root = "..\$mode"
$out = "..\Archive"
$path = [IO.Path]::GetFullPath("$root\Aphid\Aphid.exe")
$asm = [Reflection.Assembly]::LoadFile($path)
$version = $asm.GetName().version
Write-Host "Version $version found"
$archive = "$out\Aphid-$version-$mode.zip"

if ([IO.File]::Exists($archive)) {
	Write-Host "Deleting existing $archive"
	[IO.File]::Delete($archive)
}

Write-Host "Creating $archive"
Add-Type -Assembly System.IO.Compression.FileSystem

[IO.Compression.ZipFile]::CreateFromDirectory(
	$root,
	$archive,
	[IO.Compression.CompressionLevel]::Optimal,
	$false)
	
Write-Host "Zip created"