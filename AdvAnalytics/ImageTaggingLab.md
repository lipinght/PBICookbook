# Image Tagging Lab
This lab walks through the Power BI Integration with Cognitive Services for Image Tagging

**Note:** In order to do this lab, you will need access to premium or premium per user capacity.

# Preparation 
1. Download the [xlsx file](https://raw.githubusercontent.com/lipinght/PBICookbook/main/AdvAnalytics/ImageTagging.xlsx) 

2. Open Power BI Desktop, click **Get Data** on home tab, choose **Excel Workbook** and choose the xlsx file downloaded in step 1, and click **open**. 

![getdata.png](images/getdata.png)


# Image Tagging
3. Click the ... on the visualization pane, and click **get more visuals**

![getmorevis.png](images/getmorevis.png)

4. Search for  **image grid**, click into it and then click **Get it Now**

![it.png](images/it.png)

5. click on the visual **image grid** and put column **URL** into the **image URL** field

![it2.png](images/it2.png)

3. Click **Transform Data** on the home tab.

![transform.png](images/transform.png)

4. Click "Vision" in AI insights in Power Query Editor Window.

![vision.png](images/vision.png)

5. In the pop up window, select **tag images** and choose **URL** as the column in Image to be analyzed, click **OK**

![it3.png](images/it3.png)

6. The tagged labels are return. click **Close & Apply** on the home tab.

![it4.png](images/it4.png)

7. Click on the **slicer** visual and put column **tag images.tag** into the field **Field**

![it5.png](images/it5.png)

8. Now you can interact with the visuals using tagss

![it6.png](images/it6.png)
