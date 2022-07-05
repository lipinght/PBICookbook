# Image Tagging Lab
This lab walks through the Power BI Integration with Cognitive Services for Image Tagging

**Note:** In order to do this lab, you will need access to premium or premium per user capacity. Do the [prerequisite](Prerequisite.md#provision-workspace) before starting the lab

# Image Tagging
1. Click the ... on the visualization pane, and click **get more visuals**

![getmorevis.png](images/getmorevis.png)

2. Search for  **image grid**, click into it and then click **Get it Now**

![it.png](images/it.png)

3. Download the [xlsx file](https://raw.githubusercontent.com/lipinght/PBICookbook/main/AdvAnalytics/ImageTagging.xlsx) (Open in a new window, right click, click **save as**)

4. Open Power BI Desktop, click **Get Data** on home tab, choose **Excel Workbook** and choose the xlsx file downloaded in step 1, and click **open**,  a preview of the data will load, click **transform data**.

![getdata.png](images/getdata.png)

5. Once in power query editor view, click **Use First Row as Headers** and click **Close & Apply**.

![rowheader.png](images/rowheader.png)

6. Click "Vision" in AI insights in Power Query Editor Window.

![vision.png](images/vision.png)

7. In the pop up window, select **tag images** and choose **URL** as the column in Image to be analyzed, click **OK**

![it3.png](images/it3.png)

**Note:** It triggers a warning on data privacy.In the next screen, select **Ignore Privacy Levels checks for this file > Save**.

![privacy.png](images/privacy.png)

8. The tagged labels are return. click **Close & Apply** on the home tab.

![it4.png](images/it4.png)

9. click on the visual **image grid** and put column **URL** into the **image URL** field

![it2.png](images/it2.png)

10. Click on the **slicer** visual and put column **tag images.tag** into the field **Field**

![it5.png](images/it5.png)

11. Now you can interact with the visuals using tagss

![it6.png](images/it6.png)
