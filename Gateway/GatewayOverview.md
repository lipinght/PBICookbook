## Overview
The on-premises data gateway provides quick and secure data transfer between on-premises data and several Microsoft cloud services. These services include Power BI, Power Apps, Power Automate, Azure Analysis Services, 
and Azure Logic Apps. In this context, on-premise data includes data only available on virtual networks, even if already hosted in the cloud. 

## High level architecture
![architecture.png](https://docs.microsoft.com/en-us/data-integration/gateway/media/service-gateway-onprem-indepth/on-prem-data-gateway-how-it-works.png)

| Topic | Description |
|:------------------------:|:-----------------------:|
| [Overview](https://docs.microsoft.com/en-us/data-integration/gateway/service-gateway-onprem) | What is the on-premises data gateway | 
| [Architecture](https://docs.microsoft.com/en-us/data-integration/gateway/service-gateway-onprem-indepth) | Overview of the on-premises data gateway architecture | 
| [Install](https://docs.microsoft.com/en-us/data-integration/gateway/service-gateway-install) | Steps to install the on-premises gateway | 
| [Minimum requirements](https://docs.microsoft.com/en-us/data-integration/gateway/service-gateway-install#minimum-requirements) | .NET Framework 4.6 (Gateway release August 2019 and earlier) <br /> .NET Framework 4.7.2 (Gateway release September 2019 and later) <br /> A 64-bit version of Windows 8 or a 64-bit version of Windows Server 2012 R2 with current TLS 1.2 and cipher suites <br /> 4 GB disk space for performance monitoring logs (in default configuration) |
| [Recommended requirements](https://docs.microsoft.com/en-us/data-integration/gateway/service-gateway-install#recommended) | An 8-core CPU <br /> 8 GB of memory <br /> A 64-bit version of Windows Server 2012 R2 or later <br /> Solid-state drive (SSD) storage for spooling. | 
| [Configure](https://docs.microsoft.com/en-us/data-integration/gateway/service-gateway-app) | Configure a new on-premises data gateway |
| [Manage](https://docs.microsoft.com/en-us/data-integration/gateway/service-gateway-manage) | Manage an on-premises data gateway |
| [Monitor](https://docs.microsoft.com/en-us/data-integration/gateway/service-gateway-performance) | Monitor an on-premises data gateway |
| [Troubleshoot](https://docs.microsoft.com/en-us/data-integration/gateway/service-gateway-tshoot) | Troubleshoot an on-premises data gateway |  
| [Supported data sources](https://docs.microsoft.com/en-us/power-bi/connect-data/power-bi-data-sources) | List of supported data sources |
| [Add/Remove data sources](https://docs.microsoft.com/en-us/power-bi/connect-data/service-gateway-data-sources) | Add or remove a data source |


## Considerations
*	Don't install a gateway on a computer, like a laptop, that might be turned off, asleep, or disconnected from the internet
*	If a gateway uses a wireless network, its performance might suffer
*	You could install other applications on the gateway machine, but this may degrade gateway performance
* Currently, Microsoft actively supports only the last six releases of the on-premises data gateway. We release a new update for data gateways every month
* To measure your network throughput, you can use the [Azure Speed Test app](https://azurespeedtest.azurewebsites.net/)

