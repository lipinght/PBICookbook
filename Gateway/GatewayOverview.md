## Overview
The on-premises data gateway provides quick and secure data transfer between on-premises data and several Microsoft cloud services. These services include Power BI, Power Apps, Power Automate, Azure Analysis Services, 
and Azure Logic Apps. In this context, on-premise data includes data only available on virtual networks, even if already hosted in the cloud. 

## High level architecture
![architecture.png](https://docs.microsoft.com/en-us/data-integration/gateway/media/service-gateway-onprem-indepth/on-prem-data-gateway-how-it-works.png)

| Topic | Description |
|:------------------------:|:-----------------------:|
| [Overview](https://docs.microsoft.com/en-us/data-integration/gateway/service-gateway-onprem) | What is the on-premises data gateway | 
| [Architecture](https://docs.microsoft.com/en-us/data-integration/gateway/service-gateway-onprem-indepth) | Overview of the on-premises data gateway architecture | 
| [Which version to use](https://docs.microsoft.com/en-us/power-bi/connect-data/service-gateway-personal-mode#on-premises-data-gateway-vs-on-premises-data-gateway-personal-mode) | Differences between the personal and standard versions |
| [Install](https://docs.microsoft.com/en-us/data-integration/gateway/service-gateway-install) | Steps to install the on-premises gateway | 
| [Minimum requirements](https://docs.microsoft.com/en-us/data-integration/gateway/service-gateway-install#minimum-requirements) | .NET Framework 4.6 (Gateway release August 2019 and earlier) <br /> .NET Framework 4.7.2 (Gateway release September 2019 and later) <br /> A 64-bit version of Windows 8 or a 64-bit version of Windows Server 2012 R2 with current TLS 1.2 and cipher suites <br /> 4 GB disk space for performance monitoring logs (in default configuration) |
| [Recommended requirements](https://docs.microsoft.com/en-us/data-integration/gateway/service-gateway-install#recommended) | An 8-core CPU <br /> 8 GB of memory <br /> A 64-bit version of Windows Server 2012 R2 or later <br /> Solid-state drive (SSD) storage for spooling. | 
| [Configure](https://docs.microsoft.com/en-us/data-integration/gateway/service-gateway-app) | Configure a new on-premises data gateway |
| [High availability and load balancing](https://docs.microsoft.com/en-us/data-integration/gateway/service-gateway-high-availability-clusters) | Configure a gateway cluster for HA and load balancing | 
| [Manage](https://docs.microsoft.com/en-us/data-integration/gateway/service-gateway-manage) | Manage an on-premises data gateway |
| [Monitor](https://docs.microsoft.com/en-us/data-integration/gateway/service-gateway-performance) | Monitor an on-premises data gateway |
| [Troubleshoot](https://docs.microsoft.com/en-us/data-integration/gateway/service-gateway-tshoot) | Troubleshoot an on-premises data gateway |  
| [Supported data sources](https://docs.microsoft.com/en-us/power-bi/connect-data/power-bi-data-sources) | List of supported data sources |
| [Add/Remove data sources](https://docs.microsoft.com/en-us/power-bi/connect-data/service-gateway-data-sources) | Add or remove a data source |


## Considerations
*	Don't install a gateway on a computer, like a laptop, that might be turned off, asleep, or disconnected from the internet
*	If a gateway uses a wireless network, its performance might suffer
* The gateway is intended to run on a server, rather than a user machine, which should make it more reliable for uptime and performance.
* The production gateway cluster should be configured with at least two servers to achieve high availability and load balancing. Dev/test gateways can have less nodes and less resources
*	You could install other applications on the gateway machine, but this may degrade gateway performance
* Currently, Microsoft actively supports only the last six releases of the on-premises data gateway. We release a new update for data gateways every month
* To measure your network throughput, you can use the [Azure Speed Test app](https://azurespeedtest.azurewebsites.net/)
* The gateway should always be configured with more than one [gateway administrator](https://docs.microsoft.com/en-us/data-integration/gateway/service-gateway-manage#manage-gateway-admins), in the event of employee terminations,transfers or vacations

# Naming conventions example
| Entity | Name |
|:------------------------:|:-----------------------:|
|Gateway cluster - production|DataGateway-Prod|
|Gateway cluster - development|DataGateway-Dev|
|Node 1 of the production cluster|DataGW-Prod-Node1|
|Node 2 of the production cluster|DataGW-Prod-Node2|
|Node 1 of the development cluster|DataGW-Dev-Node2|
|Data source production|EnterpriseDWProd|
|Data source production|EnterpriseSharepointProd|


 
