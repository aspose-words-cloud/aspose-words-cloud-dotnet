param (
    [string]$filepath = ""
)

$fixedValue = '<?xml version="1.0" encoding="UTF-8"?>'
if (![System.IO.File]::Exists($filepath))
{
    Write-Output "Test report file '$filepath' not found."
    exit -1
}

$content = Get-Content -Path $filepath
if ($content[0] -eq $fixedValue)
{
    Write-Output "Test report file '$filepath' already fixed."
    exit -1
}

#Create a new array
$Output = @()
#Add new text
$Output += $fixedValue
#Append old text from content
$Output += $content

$Output | Out-file -Encoding "UTF8" $filepath
Write-Output "Test report file '$filepath' successfully fixed."