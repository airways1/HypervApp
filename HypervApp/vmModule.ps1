# Merge-VHD -Path 'C:\hyperv\vhd\xx_29F59E56-E3C2-4102-A1D3-57497C5ACB95.avhdx' -DestinationPath 'c:\hyperv\vhd\xx.vhdx'
#Merge-VHD -Path 'C:\hyperv\vhd\xx_7117F345-D630-447B-A81B-982E609C808B.avhdx' -DestinationPath 'c:\hyperv\vhd\xx.vhdx'
function GetVm()
{
(Get-Vm).Name
}

function Get-VHDChain
{
	<#
	.SYNOPSIS
	Finds all the parents of a Hyper-V virtual hard disk 

	.DESCRIPTION
	Finds all the parents of a Hyper-V virtual hard disk 
	

	.EXAMPLE
	Get-VHDChain -Path 'e:\hyperv\vhd\example.avhdx'


	.NOTES
		v1.0
		Author: linchao
		Authored date: June 28, 2019
		Copyright no purpose
	#>

	#requires -Modules Hyper-V
   
	param([Parameter(Mandatory=$true)][String]$Path)
    $Result=@($Path)
    do{
      $Path = (Get-VHD -Path $Path).ParentPath
      if(-not [string]::IsNullOrEmpty($path)){
        $Result+=$Path
      }
    }
	while($Path)
	$Result
} 
function listDisk()
{
param( [String]$Name)
(Get-VMHardDiskDrive -VMName $Name).Path
}
function MergeDisk()
{
param([string]$DiskPath)
#$Key = "HKLM:\SOFTWARE\Microsoft\Virtual Machine\Guest\Parameters"
#$HVName = (Get-ItemProperty -Path $Key).PhysicalHostName #主機名稱
#$VName = "xx"
#$VMDisks = Get-VMHardDiskDrive -VMName $VName

#foreach ($Disk in ($VMDisks | Where { $_.Path -match ":" })) {
#    $DiskTree=Get-VHDChain -Path $Disk.Path    
#}
$DiskTree=Get-VHDChain -Path $DiskPath
#$DiskTree| %{[System.IO.Path]::GetFileNameWithoutExtension($_)}
$srcDir = (Get-Item -Path ".\").FullName # $PSScriptRoot
$workDir = $srcDir + "\newhd\"

if(!(Test-Path -Path $workDir )){
    New-Item -ItemType directory -Path $workDir
}
$dstFiles=@()
For ($i=0; $i -lt $DiskTree.Length; $i++) {
    $fileName=[System.IO.Path]::GetFileName($DiskTree[$i])
    Copy-Item -Path $DiskTree[$i] -Destination "$workDir$fileName"
    $dstFiles += "$workDir$fileName"
}

For ($i=0; $i -lt $dstFiles.Length-1; $i++) {
    Merge-VHD -Path $dstFiles[$i] -Confirm:$false -Force   
}
$workDir
}