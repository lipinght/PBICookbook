This labs walks through different AI Visuals in Power BI

| Feature | Overview | 
|:------:|:---------:|
|[Key influencers](https://github.com/lipinght/pbideployment/blob/main/AdvAnalytics/AIVisualLab.md#Key-Influencers)|The key influencers visual helps you understand the factors that drive a metric or attribute you're interested in|
|[Q & A](https://github.com/lipinght/pbideployment/blob/main/AdvAnalytics/AIVisualLab.md#Q&A)|The Q&A feature allows your end users to ask questions about your data in power bi using NLP|
|[Decomposition tree](https://github.com/lipinght/pbideployment/blob/main/AdvAnalytics/AIVisualLab.md#Decomposition-Tree)|The decomposition tree visual in Power BI lets you visualize data across multiple dimensions|
|[Smart narrative](https://github.com/lipinght/pbideployment/blob/main/AdvAnalytics/AIVisualLab.md#Smart-Narrative)|The smart narrative visualization helps you quickly summarize visuals and reports|
|[Anomaly detection](https://github.com/lipinght/pbideployment/blob/main/AdvAnalytics/AIVisualLab.md#Anomaly-Detection)|Anomaly detection helps you enhance your line charts by automatically detecting anomalies in your time series data|

# Preparation

1. Download the [csv file](https://raw.githubusercontent.com/lipinght/PBICookbook/main/AdvAnalytics/heroes_information.csv) 

2. Open Power BI Desktop, click **Get Data** on home tab, choose **Text/CSV** and choose the csv file downloaded in step 1, and click **open**, click **load**.

![getdata.png](images/getdata.png)


# Key Influencers

Do the [Preparation Step](https://github.com/lipinght/pbideployment/blob/main/AdvAnalytics/AIVisualLab.md#Preparation) if it has not been done already.

* In the Visualizations pane, select a key influencer chart.

![KI.png](images/KI.png)

* With the key influencer chart visual selected:
* Drag the **Alignment** field to the Analyze.
* Drag the **Hair color** field to Explain by.
* Drag the **Gender** field to Explain by.
* Drag the **Eye color** field to Explain by.
* Drag the **Race** field to Explain by.
* Drag the **Skin color** field to Explain by.

![KIconfig.png](images/KIconfig.png)

For **What influencers Alignment to be** Select the dropdown to be **bad** within the key influencer chart 

![KIconfig2.png](images/KIconfig2.png)

click on different key influencers to explore the UI, also click on the checkbox **Only show values that are influencers** to see only key influencers. 
click on **top segments** tab and the bubbles to explore the UI for combination of Key influencers.

![KIconfig3.png](images/KIconfig3.png)

![KIconfig4.png](images/KIconfig4.png)

Copy Paste the key influencer visual, and put the new key influencer visual on the side to the original visual, for both visuals put, **publisher** in the filter pan for **filters on this visual**, for one visual, filter to "Marvel Comics" for **publisher** for the other, filter to "DC Comics" for **publisher**. With side-by-side visuals, you are able to see how key influencers different for different publisher.

![KIconfig5.png](images/KIconfig5.png)

For more details, please see [Key influencers](https://docs.microsoft.com/en-us/power-bi/visuals/power-bi-visualization-influencers) in Microsoft Doc.

# Q&A

Do the [Preparation Step](https://github.com/lipinght/pbideployment/blob/main/AdvAnalytics/AIVisualLab.md#Preparation) if it has not been done already.

* In the Visualizations pane, select a Q&A chart.

![qa.png](images/qa.png)

For **Ask a question about your data** type in **average height by race** and see the visual instantly render

![qa1.png](images/qa1.png)

Continue to type **by treemap** after the **average height by race**, and see the visual change

![qa2.png](images/qa2.png)

You can turn the Q&A rendered visual into a standard one by clicking below icon

![qa3.png](images/qa3.png)

You can also manage the setting by clicking the gear icon

![qa4.png](images/qa4.png)

In **field synonyms** you can toggle on and off the tables/columns to include or exclude from Q&A and management synonyms. When a field in a different visual is renamed, the renamed field will show as suggested term in Q&A. 

![qa5.png](images/qa5.png)

After the report is published, you can review questions that end users has been asking in **review questions** tab. If a questions is not understood by Q&A, you can teach Q&A to understand by clicking on **fix needed**. End user can also request a fix in Power BI Service if their question is not understood.

![qa6.png](images/qa6.png)

Go to **Teach Q&A**, if you clicked **fix needed** in **review questions**, it will also land on this page, type in **average height by universe**, click **submit**,

![qa7.png](images/qa7.png)

Type in **publisher** after **universe refers to** click **save**. Q&A will now understand what universe means in future questions.

![qa8.png](images/qa8.png)

In **Suggest questions**, you can type in the questions that are frequently asked in **review questions** or questions you think could you relevant to your end users. suggested questions will show in the Q&A UI, and end users can click on them directly instead of typing in their own questions

![qa9.png](images/qa9.png)

# Decomposition Tree

Do the [Preparation Step](https://github.com/lipinght/pbideployment/blob/main/AdvAnalytics/AIVisualLab.md#Preparation) if it has not been done already.

* In the Visualizations pane, select a decomposition tree chart.

![dt.png](images/dt.png)

* With the decomposition tree chart visual selected:
* Drag the **Average of Height** field to the Analyze.
* Drag the **Hair color** field to Explain by.
* Drag the **Gender** field to Explain by.
* Drag the **Eye color** field to Explain by.
* Drag the **Race** field to Explain by.
* Drag the **Weight** field to Explain by.
* Drag the **Publisher** field to Explain by.

![dt1.png](images/dt1.png)

Click the "+" sign to select a dimension to expand the tree with, you can alternatively select **high value** or **low value**, this will let AI decide which dimension to expand the tree with next. AI will pick the dimension that is most important in driving the high/low value of what you have selected to analyze. If a dimension is selected by AI, there will a light bulb next to the name.

![dt2.png](images/dt2.png)

You can select to lock level, by clicking the lock icon next to the dimension name, if you do so, end users will not be able to ellapse the tree on and before this level. 

![dt3.png](images/dt3.png)

# Smart Narrative

Do the [Preparation Step](https://github.com/lipinght/pbideployment/blob/main/AdvAnalytics/AIVisualLab.md#Preparation) if it has not been done already.

First create a few visuals on a blank page.
* In the Visualizations pane, select a stacked bar chart.

* With the stacked bar chart visual selected:
* Drag the **Alignment** field to Axis.
* Drag the **Average of Weight** to Values.

![sn1.png](images/sn1.png)

* In the Visualizations pane, select a 100% stacked column chart.

* With the 100% stacked column chart visual selected:
* Drag the **Hair color** field to Axis.
* Drag the **Alignment** field to Legend.
* Drag the **Count of Alignment** to Values.

![sn2.png](images/sn2.png)

* In the Visualizations pane, select a smart narrative chart. A text box will automatically render based on the content you have on the page.

![sn3.png](images/sn3.png)

![sn4.png](images/sn4.png)


You can add your own narratives by click on the smart narrative text box, in this example, type in **Average height is** , then click on **+Value** . In **How would you calculate this value**, type in **Average height**, in **name your value**, type in **avgheight**, click **save**

![sn6.png](images/sn6.png)

The text box content (including the values you created) will dynamically update as you cross filter on other visuals

![sn7.png](images/sn7.png)

You can click **Review** to see and manage all the values you have created.

![sn5.png](images/sn5.png)

# Anomaly Detection

Download the [csv file](https://raw.githubusercontent.com/lipinght/PBICookbook/main/AdvAnalytics/train.csv) 

Open Power BI Desktop, click **Get Data** on home tab, choose **Text/CSV** and choose the csv file downloaded in step 1, and click **open**, click **load**.

![getdata.png](images/getdata.png)

* In the Visualizations pane, select a line chart.

* With the line chart visual selected:
* Drag the **Order Date** field to Axis.
* Drag the **Sales** to Values.

![ad.png](images/ad.png)

In the Analytics well, expand **Find anomalies**, click **+add**

![ad1.png](images/ad1.png)

Drag **Region, Segment, City, Category** to explain by, and click **Apply**

Click on different anomality data points to see some of the possible explanations.

![ad2.png](images/ad2.png)

You can add the explanations visuals to report by clicking on **add to report**