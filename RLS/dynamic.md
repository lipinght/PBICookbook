# Dynamic Row-level Security in Power BI

Row-level security (RLS) in Power BI is used to restrict access to a subset of data at row level for defined user. RLS works for both import mode or DirectQuery mode. Below are the steps to set up RLS in Power BI. Dynamic RLS uses DAX functions username() or userprincipalname() within your security model. Typically in dynamic RLS, there will be a security profile table that contains at least two columns, one will list the dimensions RLS to be filtered on, and the other will list the users that have access to those filtered data. The security profile table will be joined with the dimension table that contains the dimension the RLS is filtered on. An example of security profile table looks like below.
| Country | Analyst | 
|:------:|:-----:|
| Canada | john@contoso.com |

# Tutorial 

1.	Load your tables into Power BI, establish relationships between tables as needed.
2.	On the “Modelling” Tab, select “Manage Rols”.
![managerole.png](images/ManageRole.PNG)
3.	Under roles, click “Create”, give the role a descriptive name.
![CreateRole.png](images/CreateRole.PNG)
4.	Choose the security profile table where you want to set up RLS, and in “Table filter DAX expression” box, type in [ColumnName] = ” username() or userprincipalname()”. Here ColumnName refers to the column name of the column where you have usernames listed. You can type the column name directly or click the … next to the table name, select “Apply Filters” and pick the column name. For difference between username() and userprinciplename(), please see [here]( https://docs.microsoft.com/en-us/power-bi/admin/service-admin-rls#using-the-username-or-userprincipalname-dax-function)
![AddFilter.png](images/AddFilter.PNG) 
In below example the role “Analyst” is set up so that the end users assigned to the role can only see data filtered down to the dimension that they are mapped to in the table 
![DynamicDAX.png](images/DynamicDAX.PNG)
5.	Click “save”
6.	Test the role by clicking “View as” on the “Modelling” tab
![ViewAs.png](images/ViewAs.PNG)
7.	Select the role that you have created and “other user”, type in the username you want to test, and click “ok”
![DynamicViewAs.png](images/DynamicViewAs.PNG)
9.	Once testing completes in desktop and you can publish the pbix to power bi service. In order to set up security model in power bi service, click the three dots on the right hand side of dataset and select “security”
![DatasetOption.png](images/DatasetOption.PNG)
![DatasetSecurity.png](images/DatasetSecurity.PNG)
10.	You can add end users or groups to the role, and click “add”, for group types supported, please see [here]( https://docs.microsoft.com/en-us/power-bi/admin/service-admin-rls#add-members) 
![AddMember.png](images/AddMember.PNG)
11.	You can test what data members in the role can see by clicking the “…” next to the role name, and click “test as”
![TestRole.png](images/TestRole.PNG)

# Consideration

*	Row-level security filter uses single-directional filters by default, if you need to enable bi-directional filtering for RLS, you can select the relationship and tick the “Apply security filter in both directions” box. 

*	In Power BI Service, RLS does not apply to admin, members, contributors in Power BI workspaces, if you want to set up RLS for end users, make sure they are set  up as Viewer at workspace level. 

# Useful Links

[Row-level security Microsoft Docs](https://docs.microsoft.com/en-us/power-bi/admin/service-admin-rls)
