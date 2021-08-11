# Deployment Pipeline Documentation

| Documentation | Description | 
|:------:|:-----:|
| [Get Started with Deployment Pipeline](https://docs.microsoft.com/en-us/power-bi/create-reports/deployment-pipelines-get-started) | This is to a tutorial to build first deployment pipeline |
| [Deployment Pipeline Best Practice](https://docs.microsoft.com/en-us/power-bi/create-reports/deployment-pipelines-best-practices) | This is microsoft documentation that outlines some of the best practice for deployment pipeline |
| [Deployment Pipeline Troubleshooting](https://docs.microsoft.com/en-us/power-bi/create-reports/deployment-pipelines-troubleshooting) | This is microsoft documentation that outlines FAQs for troubleshooting deployment pipeline | 
| [Understanding Deployment Process](https://docs.microsoft.com/en-us/power-bi/create-reports/deployment-pipelines-process) | This is microsoft documentation that details the deployment process |
| [Incremental Refresh in Deployment Pipelines](https://github.com/lipinght/pbideployment/blob/main/DeploymentPipeline/DeploymentPipeline.md#incremental-refresh-in-deplooyment-pipelines) | This section outlines the considerations for using dataset with incremental refresh in Deployment Pipelines |


# Incremental Refresh in Deployment Pipelines
* Incremental Refresh is supported in Deployment Pipeline. 
* With deployment pipelines, you can make updates to a dataset with incremental refresh while retaining both data and partitions. When you deploy the dataset, the policy is copied along.
* An incremental dataset, once published and refreshed, only allows incremental refreshes via the Power BI UI. For a full refresh, you will need to use the XMLA endpoints.
* Deploying changes to an incremental dataset via the pipelines will not force a full refresh in most cases. Incremental refreshes in the target workspace need to be triggered for most of changes to start working.
* Add/delete columns are supported in deployment pipeline, but dataset deployed to target workspace will only allow incremental refresh.
* Adding measures are supported by deployment pipeline, measures will work in target workspace without having to refresh the dataset. If a dataset is not set up with incremental refresh, measures added will only work once the dataset is refreshed in the target workspace.
* Renaming columns are not supported in deployment pipeline
* Renaming the measures will require the dataset in the target workspace to be refreshed.
