using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TrainingType : MonoBehaviour
{
    public bool isTeam, isChaser, isBeater, isKeeper, isSeeker;
    public int staminaCost;
    public int dodgeExp, intExp, passExp, shotExp, speedExp, tackleExp, locateExp, blockExp, sightExp, reachExp, grabExp;
    public string trainingName;
    public TMP_Text nameOfTraining, stamCost, dodgeText, speedText, interceptText, passingText, shootingText, tackleText, locateText, blockText, sightText, reachText, grabText;

    public void PrepList()
    {
        nameOfTraining.text = trainingName;
        stamCost.text = staminaCost.ToString();
        dodgeText.text = dodgeExp.ToString();
        speedText.text = speedExp.ToString();
        interceptText.text = intExp.ToString();
        passingText.text = passExp.ToString();
        shootingText.text = shotExp.ToString();
        tackleText.text = tackleExp.ToString();
        locateText.text = locateExp.ToString();
        blockText.text = blockExp.ToString();
        sightText.text = sightExp.ToString();
        reachText.text = reachExp.ToString();
        grabText.text = grabExp.ToString();

        if (staminaCost > 0) stamCost.GetComponent<TMP_Text>().color = Color.green;
        if (staminaCost < 0) stamCost.GetComponent<TMP_Text>().color = Color.red;

        if (dodgeExp > 0) dodgeText.GetComponent<TMP_Text>().color = Color.green;
        if (dodgeExp < 0) dodgeText.GetComponent<TMP_Text>().color = Color.red;

        if (intExp > 0) interceptText.GetComponent<TMP_Text>().color = Color.green;
        if (intExp < 0) interceptText.GetComponent<TMP_Text>().color = Color.red;

        if (passExp > 0) passingText.GetComponent<TMP_Text>().color = Color.green;
        if (passExp < 0) passingText.GetComponent<TMP_Text>().color = Color.red;

        if (shotExp > 0) shootingText.GetComponent<TMP_Text>().color = Color.green;
        if (shotExp < 0) shootingText.GetComponent<TMP_Text>().color = Color.red;

        if (speedExp > 0) speedText.GetComponent<TMP_Text>().color = Color.green;
        if (speedExp < 0) speedText.GetComponent<TMP_Text>().color = Color.red;

        if (tackleExp > 0) tackleText.GetComponent<TMP_Text>().color = Color.green;
        if (tackleExp < 0) tackleText.GetComponent<TMP_Text>().color = Color.red;

        if (locateExp > 0) locateText.GetComponent<TMP_Text>().color = Color.green;
        if (locateExp < 0) locateText.GetComponent<TMP_Text>().color = Color.red;

        if (blockExp > 0) blockText.GetComponent<TMP_Text>().color = Color.green;
        if (blockExp < 0) blockText.GetComponent<TMP_Text>().color = Color.red;

        if (sightExp > 0) sightText.GetComponent<TMP_Text>().color = Color.green;
        if (sightExp < 0) sightText.GetComponent<TMP_Text>().color = Color.red;

        if (reachExp > 0) reachText.GetComponent<TMP_Text>().color = Color.green;
        if (reachExp < 0) reachText.GetComponent<TMP_Text>().color = Color.red;

        if (grabExp > 0) grabText.GetComponent<TMP_Text>().color = Color.green;
        if (grabExp < 0) grabText.GetComponent<TMP_Text>().color = Color.red;
    }

    public void ExecuteTraining()
    {
        if (isTeam)
        {

        }
        else if (isChaser)
        { 

        }
        else if (isBeater)
        {

        }
        else if (isKeeper)
        {

        }
        else if (isSeeker)
        {

        }

        //Save Exp
        //Adv to Next Day
        GameObject.Find("ManagementSeasonTracker").GetComponent<ManagementSeasonTracker>().OpenPostTrainingMenu();
        GameObject.Find("ManagementTeamTraining").GetComponent<ManagementTeamTraining>().UpdateSliderOnPostTrainingPage();
    }
}
