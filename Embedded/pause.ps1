param (
    [string]$EmbeddedName
)


Connect-AzAccount -Identity 

Suspend-AzPowerBIEmbeddedCapacity -Name $EmbeddedName -PassThru