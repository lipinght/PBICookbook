# Auto ML Lab
This lab walks through how to use Auto ML feature within Power BI Service

**Note:** In order to do this lab, you will need access to premium or premium per user capacity. Do the [prerequisite](https://github.com/lipinght/pbideployment/blob/main/AdvAnalytics/Prerequisite.md#provision-workspace) before starting the lab


1. Go to Powerbi.com and nagivate to the workspace you created in the [prerequisite](https://github.com/lipinght/pbideployment/blob/main/AdvAnalytics/Prerequisite.md#provision-workspace) or another workspace that is in a premium or premium per user capacity

2. Click on **New** and select **Dataflow**

![automl.png](images/automl.png)

3. Click on **Add new tables** 

![automl2.png](images/automl2.png)

4. Click on **Text/CSV** 

![automl21.png](images/automl21.png)

in the next window, for **File path or URL** input below url, click **Next**
https://raw.githubusercontent.com/lipinght/PBICookbook/main/AdvAnalytics/OnlineShoppersIntention.csv
 
![automl22.png](images/automl22.png)

click **Transform Data** in the next page.

5. Scoll to the right, and click the "ABC" on column **Revenue** and change it to **True/False**, click **Add new Step** when prompted and click **Save & Close**

![automl3.png](images/automl3.png)

6. Give your dataflow a name, in this case "OnlineShopperIntention" and click **Save**


7. Click second icon "apply ml model" under actions and click on "Add a machine learning model" 

![automl5.png](images/automl5.png)

8. For Outcome Column, select the dropdown to be **Revenue**, click **Next**

![automl7.png](images/automl7.png)

9. For Choose a target outcome, select the dropdown to be **true**, click **Next**

![automl8.png](images/automl8.png)

10. You can select the attributes to be included in the model, Power BI makes recommendations, we will stick with the recommendations, and click **Next**

![automl9.png](images/automl9.png)

11. Type in Model name, in this case "ShopperIntentionModel", Choose a proper amount of time for model to train, taking into account the lab durations, **we will do "21 minutes"**, in reality, you want to give it sufficient time to go through all the algorithms and hyperprarameters and click **Save and Train**

![automl10.png](images/automl10.png)

The training will kick off, in workspace view, you will see the dataflow refresh is now in motion with the wheel running next to the refreshed timestamp

![automl6.png](images/automl6.png)

**Note: wait for 1 minute, if a warning sign appears next to the refresh timestamp, click the refresh button below, if no warning sign appears and refresh is still going, please go to do [other Labs](https://github.com/lipinght/pbideployment/blob/main/AdvAnalytics/Labs.md) while the training is running and come back to step 12 later once training is finished.**

![autom23.png](images/automl23.png)

12. Click on the **Machine Learning Models** tab, you will be able to see the status of the model. Once the model training process is finished, the status will be updated to **Trained**.

![automl12.png](images/automl12.png)

13. Click on the second icon under Actions to view training report 


![automl13.png](images/automl13.png)

14. Within the training report, you get three tabs, for "Model Performance", you are able to choose the probability Threshold to achive an balance ebtween precision and recall. Click on "see top predictors" button, to see the feature importance. The tab "Accuracy Report" explains model performance metrics, and the "Training Details" outlines details on training details, such as how many iterations were run, what model was chosen and what hyperparameters were usad

![automl14.png](images/automl14.png)

![automl15.png](images/automl15.png)

![automl16.png](images/automl16.png)

15. Click **Apply Model** on top right, choose the table you want to apply the model to (OnlineShoppersIntention), choose your threshold and click **save and apply**, you will see two "enriched" tables being created in the dataflow.

![automl17.png](images/automl17.png)

![automl18.png](images/automl18.png)

16. For this binary prediction model, it adds 4 output columns to the enriched output table: Outcome, PredictionScore, PredictionExplanation, and ExplanationIndex. 

![automl19.png](images/automl19.png)

17. You can also connect to the Power BI Dataflows from desktop, and start buiding visuals from the prediction 

![automl20.png](images/automl20.png)
