param (
    [string]$EmbeddedName
)


Connect-AzAccount -Identity 

$CapacityTest = Test-AzPowerBIEmbeddedCapacity -Name $EmbeddedName

if ($CapacityTest)
{
    $CapacityState = Get-AzPowerBIEmbeddedCapacity -Name $EmbeddedName

    if($CapacityState.State -eq "Succeeded")
    {
        Write-Host "Capacity $EmbeddedName already resumed."
    }
    else
    {
        Resume-AzPowerBIEmbeddedCapacity -Name $EmbeddedName -PassThru
        Write-Host "Capacity $EmbeddedName resumed."
    }
}
else
{
        Write-Host "Capacity $EmbeddedName does not exist."
}

Write-Host "Exit..."