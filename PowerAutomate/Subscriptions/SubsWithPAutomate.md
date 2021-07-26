# Report Distribution Leveraging RLS from Underlying Dataset Using Power Automate 

## Limitations of native email subscription 
When you have paginated report on a premium/embedded capacity, you can set up email subscriptions for yourself and other users in your organization. When you set up email subscription, Power BI will send an email with the report as an attachment with a frequency of your choice. You can choose to have the attachment in different format, including Excel, PPT, PDF etc, up to 25MB.
However, currently subscriptions sent to all recipients are with the same attachments, this is because  report attachment reflects the data based on your permissions, and not the recipients'.


| [Overview](#overview) 
| [Power BI Dataset](#power-bi-dataset) 
| [Power Automate set-up](#power-automate-set-up) 
| [Considerations](#considerations) 
| [Resources](#resources)

## Overview
This blog covers an alternative approach using [Power Automate](https://preview.flow.microsoft.com/en-us/), in which you are able to send different attachments to recipients based on their roles set up in Power BI dataset's security model.

![overview.png](images/overview.png)


## Power BI Dataset

1. Have a Power BI dataset in import or direct query mode. Once published, the datasets should <b>not</b> be configured with the SSO option in order for this to work. For this example, data from the [Adventure Works sample database](https://docs.microsoft.com/en-us/sql/samples/adventureworks-install-configure?view=sql-server-ver15&tabs=ssms) is used. 

![dataset_1.png](images/dataset_1.png)

2. Create security roles and define a relevant [Row-Level Security(RLS)](https://docs.microsoft.com/en-us/power-bi/admin/service-admin-rls) model. In the example below we have a very simple RLS model, where the product sales are filtered by product category, depending on what role someone is part of. People in the <b>Caps</b> role will only be able to see caps sales, while people in the <b>Gloves</b> role will only be able to see Gloves sales. 

![roles_1.png](images/roles_1.png)

3. Once the dataset is published to the Power BI service, you can add people or groups from your Azure Active Directory to the created roles. 

![roles_2.png](images/roles_2.png)

4. The RLS roles can be tested by the author in Power BI Desktop or the Power BI service, to make sure they behave as intended. 

![roles_3.png](images/roles_3.png)

5. Using [Power BI Report Builder](https://docs.microsoft.com/en-us/power-bi/paginated-reports/report-builder-power-bi), connect to the dataset mentioned above and create a paginated report.

![paginated_1.png](images/paginated_1.png)

![paginated_2.png](images/paginated_2.png)

6. Publish the paginated report to a workspace on the Power BI service backed by dedicated capacity. 

## Power Automate set-up

### The Power Automate Approach requires a paginated report being built on top of a Power BI dataset that has security model set up as described in the last section. Additionally, a Power automate is set up in below steps in order to leverage the security model in the underlying Power BI dataset.

1. Create Power Automate Flow from Template!
   Go to flow.Microsoft.com  and in the search bar type in "paginated report", choose the template "Export a Power BI paginated report for each row in an Excel Online table", sign in and continue in the next page. 
  
![template_1.png](images/template_1.png)  
   
2. Customize template
   Once in the flow, you can set the recurrence of the subscriptions. The next step is to create a Excel sheet, with a column named "EmailAddress", and list the email addresses of all recipients, format it as a table and give it a table name (e.g. UserTable), and then save the Excel sheet in OneDrive. In the next step "List rows present in a table", take the one drive location for the Excel sheet and use dropdown to pick the table name. 
   
![template_2.png](images/template_2.png)  

![template_3.png](images/template_3.png)  

   In the "Apply to each" step, use the dropdown to pick the workspace name and the Paginated Report name, pick the export format (e.g. PDF) and then click on the field "Identities Username -1" use "add dynamic content" to add the column name "EmailAddress".
   
![template_4.png](images/template_4.png)     

   In "Set output file name" step, give a value for the output file, note the value will need to include file extension. Using "utcNow()" (in dynamic content->expressions ) as part of the value will include the timestamp of when the subscription is sent.
   
![template_5.png](images/template_5.png)     

   Next step is the delete the "Switch" action from the template and, by clicking the "..." on the activity, then click on "add an action" and type in "send" and choose "Send an email (V2)".
 
![template_6.png](images/template_6.png)     

![template_7.png](images/template_7.png)     

![template_8.png](images/template_8.png)     

   In the email setting, choose "Email Address" from "Add dynamic content" in "To" field, and type in the subject of your choice. For "Attachment Name -1", use "OutputFileName" from "Add dynamic content", and for "Attachments Content" use "File Content" from "Add dynamic content".

![template_9.png](images/template_9.png)     

   You can set Job parallelization to allow parallel processing and shorten execution time. To set job parallelization, click the "..." on "Apply to each", click on "Settings" and then turn on "Concurrency Control" and set degree of parallelism and click "Done".
   
![template_10.png](images/template_10.png)     

![template_11.png](images/template_11.png)     

3. The next step is to save the flow and test. Once saved, click on "Test" on upper right hand side and click on "manually" test. This will trigger the flow to run.
  
![template_12.png](images/template_12.png)        

4. Once run has completed, the recipients will receive email subscription with attachment. In our example,  user A is set up in the security model of Power BI dataset to see "Gloves" only and user B is able to see everything.

User A email attachment.

![output_1.png](images/output_1.png)       


User B email attachment.

![output_2.png](images/output_2.png)    


## CONSIDERATIONS:
* This approach requires a Power BI reserved capacity to run.
* Passing the identity username does not work when using Paginated Report to direct query SQL data sources as opposed to building Paginated Report using Power BI dataset as a source. 
* In addition to identity username, you can use parameters to do data drive subscription if you wish.
* Emails are case sensitive 
* You need to be workspace admin to set up power automate flow

## RESOURCES:

* [Export Power BI paginated reports with Power Automate](https://docs.microsoft.com/en-us/power-bi/collaborate-share/service-automate-paginated-integration)
* [Paginated Reports in Power BI Service](https://docs.microsoft.com/en-us/power-bi/consumer/end-user-paginated-report)
* [Native Email Subscription for Paginated Report in Power BI Service](https://docs.microsoft.com/en-us/power-bi/consumer/paginated-reports-subscriptions)
