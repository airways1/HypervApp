function test
{
$disks = @()
Get-VHD -Path 'c:\hyperv\vhd\xx_copy.avhdx' |  % { $disks+= $_.ParentPath }
return $disks
}
test