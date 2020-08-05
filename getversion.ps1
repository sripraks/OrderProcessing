param(
    [Parameter(Mandatory=$True, Position=1, ValueFromPipeline=$false)]
    [System.String]
    $Param1
)

#Write-Output $Param1
$version = [System.Diagnostics.FileVersionInfo]::GetVersionInfo($Param1).FileVersion.ToString()
$Env:VERSION = $version
Write-Output $version
