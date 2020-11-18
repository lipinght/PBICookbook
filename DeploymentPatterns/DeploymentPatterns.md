This Session will cover different deployment patterns for Power BI Service based on distinctive organizational needs.

# Personal BI
## Where does this pattern apply?
This scenario applies to situations where users are authoring Power BI reports for personal use with no sharing or collaboration.  

## Type of Questions this Session will Address
*	What does a Personal BI scenario look like?
*	What type of license is involved in this usage scenario?
*	What artifacts how usually involved in this usage scenario?

## Overview
*	Users use Power BI Desktop to author queries, datasets and reports
*	The .pbix file can be published to My Workspace for personal use
*	Power BI service can be used with a Power BI Free License if there is no sharing or collaboration
*	Users can use features such as reschedule data refresh, use dashboards and data alerts and cannot use features such as live connections, email subscriptions and analyze in Excel
*	On-Premises Data Gateway in Personal Mode supports data refresh , does not support live connection or direct query
*	Users can use Power BI mobile app

--Insert Diagram
## Resources
For Details of this deployment pattern, please see Page 17 of the [Power BI deployment whitepaper](https://aka.ms/PBIEnterpriseDeploymentWP).
 
 
# Small Team Collaboration
## Where does this pattern apply?
This scenario applies to situations where users are working within a small group, collaboration and distribution could be handled within a workspace.

## Type of Questions this Session will Address
*	What does a Small Team Collaboration scenario look like?
*	What type of license is involved in this usage scenario?
*	What artifacts how usually involved in this usage scenario?
*	How should I set up workspace if I have a small team collaboration on it?

## Overview
*	Users use Power BI Desktop to author queries, datasets and reports 
*	The .pbix file is recommended to be sored in a common location such as OneDrive
*	All content creators and consumers require a Pro license unless the workspace has Premium capacity (in which case users with a Power BI Free license may view content which resides in Premium)
*	For a small team collaboration, team can use the workspace for both authoring and collaboration as well as distribution and delivery of content
*	Apps can be optionally used to deliver read-only content to users, unless small teams do not desire the additional management overhead for apps
*	Users can use features such as reschedule data refresh, use email subscriptions, dashboards and data alerts and are recommended to use features such as live connections and analyse in Excel
*	On-Premises Data Gateway in Standard Mode supports data refresh, live connection or direct query
*	Users can use Power BI mobile app
*	Users can use integration with Microsoft teams to facilitate data-driven decision-making

--Insert Diagram
## Resources
For Details of this usage scenario, please see Page 18 of the [Power BI deployment whitepaper](https://aka.ms/PBIEnterpriseDeploymentWP).
 
# Large Team Collaboration and Distribution
 ## Where does this pattern apply?
This scenario applies to situations where users are working with a large team, where the complexity for collaboration and distribution needs grows beyond using just a workspace. In this scenario, the recommendation is to use a workspace for collaboration and a app for distribution.

## Type of Questions this Session will Address
*	What does a large Team Collaboration scenario look like?
* What type of license is involved in this usage scenario?
* What artifacts how usually involved in this usage scenario?
* How should I set up workspace and app if I have a large team collaboration on them?


## Overview
*	Users use Power BI Desktop to author queries, datasets and reports 
*	The .pbix file is recommended to be sored in a common location such as OneDrive
*	All content creators and consumers require a Pro license unless the workspace has been assigned to Premium capacity, in which case Power BI Free users may view content from the app (or the workspace if permissions allow).
*	For a large team collaboration, team can use the workspace for authoring and collaboration and the app distribution and delivery of content
*	Best practice is to limit access to the workspace to only the small amount of users who are handling authoring, development, and quality assurance activities
* Most users who will have read-only access to the content via app and not workspace
*	Users can use features such as reschedule data refresh, use email subscriptions, dashboards and data alerts and are recommended to use features such as live connections and analyse in Excel
*	On-Premises Data Gateway in Standard Mode supports data refresh, live connection or direct query
*	Users can use Power BI mobile app
*	Users can use integration with Microsoft teams to facilitate data-driven decision-making

--Insert Diagram
## Resources
For Details of this usage scenario, please see Page 21 of the [Power BI deployment whitepaper](https://aka.ms/PBIEnterpriseDeploymentWP).

# Enterprise Content Distribution
## Where does this pattern apply?
This scenario applies to situations where Power BI contents are created largely by central teams and there are significantly large amount of content consumers vs content creators. Power BI premium becomes a cost-effective way to manage organizational level reporting.

## Type of Questions this Session will Address
*	What does enterprise content distribution scenario look like?
* What type of license is involved in this usage scenario?
* What artifacts how usually involved in this usage scenario?


## Overview
*	Users use Power BI Desktop to author queries, datasets and reports 
*	The .pbix file is recommended to be sored in a common location such as OneDrive
* Organization/entperprise level implementation can take advantage of the cost-effectiveness Power BI Premium by having large amount of content consumers on free licenses
* Premium gives organizational level implementation dedicated compute capacity as opposed to the shared capacity that pro license gives.
* Larger implementations may also find advantages from the larger storage limits, larger dataset sizes, higher refresh rates, and other Premium features.
*	Users can use features such as reschedule data refresh, use email subscriptions, dashboards and data alerts and are recommended to use features such as live connections and analyse in Excel
*	On-Premises Data Gateway in Standard Mode supports data refresh, live connection or direct query
*	Users can use Power BI mobile app
*	Users can use integration with Microsoft teams to facilitate data-driven decision-making

--Insert Diagram
## Resources
For Details of this usage scenario, please see Page 22 of the [Power BI deployment whitepaper](https://aka.ms/PBIEnterpriseDeploymentWP).

# Centralized Datasets for Corporate Reporting
## Where does this pattern apply?
-
This scenario applies to situations where users are working within a small group, collaboration and distribution could be handled within a workspace.

## Type of Questions this Session will Address
*	What does a centralized datasets for reporting scenario look like?
*	What type of license is involved in this usage scenario?
*	What artifacts how usually involved in this usage scenario?
*	How should I set up workspaces if I want to have centralized datasets for enterprise reporting?

## Overview
-
*	Users use Power BI Desktop to author queries, datasets and reports 
*	The .pbix file is recommended to be sored in a common location such as OneDrive
*	All content creators and consumers require a Pro license unless the workspace has Premium capacity (in which case users with a Power BI Free license may view content which resides in Premium)
*	For a small team collaboration, team can use the workspace fro both authoring and collaboration as well as distribution and delivery of content
*	Apps can be optionally used to deliver read-only content to users, unless small teams do not desire the additional management overhead for apps
*	Users can use features such as reschedule data refresh, use email subscriptions, dashboards and data alerts and are recommended to use features such as live connections and analyse in Excel
*	On-Premises Data Gateway in Standard Mode supports data refresh, live connection or direct query
*	Users can use Power BI mobile app
*	Users can use integration with Microsoft teams to facilitate data-driven decision-making

--Insert Diagram
## Resources
For Details of this usage scenario, please see Page 23 of the [Power BI deployment whitepaper](https://aka.ms/PBIEnterpriseDeploymentWP).

# Embedded for Internal
## Where does this pattern apply?
-
This scenario applies to situations where users are working within a small group, collaboration and distribution could be handled within a workspace.

## Type of Questions this Session will Address
*	What does a embed for my internal organization scenario look like?
*	What type of license is involved in this usage scenario?
*	What artifacts how usually involved in this usage scenario?
* How should I set up workspace if I want to do embedded for my organization?
* How does authentication and authorization work with embedded?


## Overview
-
*	Users use Power BI Desktop to author queries, datasets and reports 
*	The .pbix file is recommended to be sored in a common location such as OneDrive
*	All content creators and consumers require a Pro license unless the workspace has Premium capacity (in which case users with a Power BI Free license may view content which resides in Premium)
*	For a small team collaboration, team can use the workspace fro both authoring and collaboration as well as distribution and delivery of content
*	Apps can be optionally used to deliver read-only content to users, unless small teams do not desire the additional management overhead for apps
*	Users can use features such as reschedule data refresh, use email subscriptions, dashboards and data alerts and are recommended to use features such as live connections and analyse in Excel
*	On-Premises Data Gateway in Standard Mode supports data refresh, live connection or direct query
*	Users can use Power BI mobile app
*	Users can use integration with Microsoft teams to facilitate data-driven decision-making

--Insert Diagram
## Resources
For Details of this usage scenario, please see Page 26 of the [Power BI deployment whitepaper](https://aka.ms/PBIEnterpriseDeploymentWP).
 
# Embedded for External
## Where does this pattern apply?
-
This scenario applies to situations where users are working within a small group, collaboration and distribution could be handled within a workspace.

## Type of Questions this Session will Address
*	What does a embedded for external customers scenario look like?
*	What type of license is involved in this usage scenario?
*	What artifacts how usually involved in this usage scenario?
*	How should I set up workspace if I want to do embedded for external customers on them?
*	How does authentication and authorization work with embedded?


## Overview
-
*	Users use Power BI Desktop to author queries, datasets and reports 
*	The .pbix file is recommended to be sored in a common location such as OneDrive
*	All content creators and consumers require a Pro license unless the workspace has Premium capacity (in which case users with a Power BI Free license may view content which resides in Premium)
*	For a small team collaboration, team can use the workspace fro both authoring and collaboration as well as distribution and delivery of content
*	Apps can be optionally used to deliver read-only content to users, unless small teams do not desire the additional management overhead for apps
*	Users can use features such as reschedule data refresh, use email subscriptions, dashboards and data alerts and are recommended to use features such as live connections and analyse in Excel
*	On-Premises Data Gateway in Standard Mode supports data refresh, live connection or direct query
*	Users can use Power BI mobile app
*	Users can use integration with Microsoft teams to facilitate data-driven decision-making

--Insert Diagram
## Resources
For Details of this usage scenario, please see Page 27 of the [Power BI deployment whitepaper](https://aka.ms/PBIEnterpriseDeploymentWP).
 
