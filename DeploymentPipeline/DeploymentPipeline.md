# Deployment Pipeline Documentation

| Documentation | Description | 
|:------:|:-----:|
| [Get Started with Deployment Pipeline](https://docs.microsoft.com/en-us/power-bi/create-reports/deployment-pipelines-get-started) | This is to a tutorial to build first deployment pipeline |
| [Deployment Pipeline Best Practice](https://docs.microsoft.com/en-us/power-bi/create-reports/deployment-pipelines-best-practices) | This is microsoft documentation that outlines some of the best practice for deployment pipeline |
| [Deployment Pipeline Troubleshooting](https://docs.microsoft.com/en-us/power-bi/create-reports/deployment-pipelines-troubleshooting) | This is microsoft documentation that outlines FAQs for troubleshooting deployment pipeline | 
| [Understanding Deployment Process](https://docs.microsoft.com/en-us/power-bi/create-reports/deployment-pipelines-process) | This is microsoft documentation that details the deployment process |
| [Automate your deployment pipeline using APIs and Azure DevOps](https://docs.microsoft.com/en-us/power-bi/create-reports/deployment-pipelines-automation) | Microsoft documentation outlineing how to automate deployment pipelines using APIs and Azure DevOps |
| [Incremental Refresh in Deployment Pipelines](#incremental-refresh-in-deployment-pipelines) | This section outlines the considerations for using dataset with incremental refresh in Deployment Pipelines |
| [Considerations](#considerations) | This section outlines some of the considerations to be taken into account when using deployment pipeline |


# Incremental Refresh in Deployment Pipelines
* Incremental Refresh is supported in Deployment Pipeline. 
* With deployment pipelines, you can make updates to a dataset with incremental refresh while retaining both data and partitions. When you deploy the dataset, the policy is copied along.
* An incremental dataset, once published and refreshed, only allows incremental refreshes via the Power BI UI. For a full refresh, you will need to use the XMLA endpoints.
* Deploying changes to an incremental dataset via the pipelines will not force a full refresh in most cases. Incremental refreshes in the target workspace need to be triggered for most of changes to start working.
* Add/delete columns are supported in deployment pipeline, but dataset deployed to target workspace will only allow incremental refresh.
* Adding measures are supported by deployment pipeline, measures will work in target workspace without having to refresh the dataset. If a dataset is not set up with incremental refresh, measures added will only work once the dataset is refreshed in the target workspace.
* Renaming columns are not supported in deployment pipeline
* Renaming the measures will require the dataset in the target workspace to be refreshed.

# Considerations
* Deployment pipeline is a premium feature, i.e. your workspace needs to be sittings in a premium capcity.
* Deployment pipeline allow you to compare artefacts between environments.
* Deployment pipeline does meta data and incremental deployment. 
* You can do **all content** or **selective content** deployment with deployment pipeline both in the UI and using APIs.
* Deployment pipeline supports backwards deployment.
* You can set up dataset rules and swap out parameters to change connection strings for different environments.
* A worksapce can only be assigned to one pipeline.
* There is currently no versioning in deployment pipeline.
* Deployment pipeline currently does not support shared datasets.
* Deployment pipeline currently does not support linked dataflows.
* While there is no Azure DevOps integration in the UI, you can set up automation for deployment pipeline using APIs and Azure DevOps with Powershell Scripts, sample PowerShell Scripts can be found [here](https://github.com/microsoft/PowerBI-Developer-Samples/tree/master/PowerShell%20Scripts)

## Considerations when using Azure DevOps and Deployment Pipeline together
* You will need to [set up service principle](https://docs.microsoft.com/en-us/power-bi/developer/embedded/embed-service-principal) in Azure AD which is used for authentication for the Powershell scripts. 
* A first manual deployment in the UI is needed to create the Test and Prod workspace.
* The service principle (or its security group) needs member or admin access to all workspaces(Dev,Test,Prod) and Deployment Pipeline itself.
* When using service principle to authenticate and connect to PowerBI, below code snippets can be used. 

```Powershell
$password = "<Client Serect>" | ConvertTo-SecureString -asPlainText -Force
$username = "<Client ID>" 
$credential = New-Object System.Management.Automation.PSCredential($username, $password)

Connect-PowerBIServiceAccount -Tenant '<Tenant ID>' -ServicePrincipal -Credential $credential
```