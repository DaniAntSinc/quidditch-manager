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
    //positions not actively training get this boost so  they can 'rest'
    int recoveryStamina = 10;

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
        if (isTeam &&
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].stamina >= -staminaCost &&
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].stamina >= -staminaCost &&
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].stamina >= -staminaCost &&
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[0].stamina >= -staminaCost &&
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[1].stamina >= -staminaCost &&
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().keeper[0].stamina >= -staminaCost &&
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].stamina >= -staminaCost
            )
        {
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].stamina += staminaCost;
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].stamina += staminaCost;
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].stamina += staminaCost;
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[0].stamina += staminaCost;
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[1].stamina += staminaCost;
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().keeper[0].stamina += staminaCost;
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].stamina += staminaCost;

            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].currentDExperience += dodgeExp;
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].currentDExperience += dodgeExp;
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].currentDExperience += dodgeExp;
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[0].currentDExperience += dodgeExp;
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[1].currentDExperience += dodgeExp;
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().keeper[0].currentDExperience += dodgeExp;
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].currentDExperience += dodgeExp;

            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].currentIExperience += intExp;
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].currentIExperience += intExp;
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].currentIExperience += intExp;

            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].currentPExperience += passExp;
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].currentPExperience += passExp;
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].currentPExperience += passExp;

            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].currentSExperience += shotExp;
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].currentSExperience += shotExp;
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].currentSExperience += shotExp;

            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].currentSpExperience += speedExp;
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].currentSpExperience += speedExp;
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].currentSpExperience += speedExp;
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].currentSpExperience += speedExp;

            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].currentTExperience += tackleExp;
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].currentTExperience += tackleExp;
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].currentTExperience += tackleExp;

            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[0].currentLSExperience += locateExp;
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[1].currentLSExperience += locateExp;

            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().keeper[0].currentBExperience += blockExp;

            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].currentSExperience += sightExp;
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].currentRExperience += reachExp;
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].currentGExperience += grabExp;

            GameObject.Find("ManagementSeasonTracker").GetComponent<ManagementSeasonTracker>().OpenPostTrainingMenu();
            GameObject.Find("ManagementTeamTraining").GetComponent<ManagementTeamTraining>().UpdateSliderOnPostTrainingPage();
        }
        else if (isChaser &&
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].stamina >= -staminaCost &&
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].stamina >= -staminaCost &&
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].stamina >= -staminaCost)
        {
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].stamina += staminaCost;
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].stamina += staminaCost;
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].stamina += staminaCost;

            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].currentDExperience += dodgeExp;
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].currentDExperience += dodgeExp;
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].currentDExperience += dodgeExp;

            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].currentIExperience += intExp;
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].currentIExperience += intExp;
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].currentIExperience += intExp;

            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].currentPExperience += passExp;
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].currentPExperience += passExp;
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].currentPExperience += passExp;

            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].currentSExperience += shotExp;
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].currentSExperience += shotExp;
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].currentSExperience += shotExp;

            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].currentSpExperience += speedExp;
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].currentSpExperience += speedExp;
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].currentSpExperience += speedExp;

            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].currentTExperience += tackleExp;
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].currentTExperience += tackleExp;
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].currentTExperience += tackleExp;

            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[0].stamina += recoveryStamina;
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[1].stamina += recoveryStamina;
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().keeper[0].stamina += recoveryStamina;
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].stamina += recoveryStamina;

            GameObject.Find("ManagementSeasonTracker").GetComponent<ManagementSeasonTracker>().OpenPostTrainingMenu();
            GameObject.Find("ManagementTeamTraining").GetComponent<ManagementTeamTraining>().UpdateSliderOnPostTrainingPage();
        }
        else if (isBeater &&
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[0].stamina >= -staminaCost &&
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[1].stamina >= -staminaCost)
        {
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[0].stamina += staminaCost;
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[1].stamina += staminaCost;
            
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[0].currentDExperience += dodgeExp;
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[1].currentDExperience += dodgeExp;
           
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[0].currentLSExperience += locateExp;
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[1].currentLSExperience += locateExp;

            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].stamina += recoveryStamina;
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].stamina += recoveryStamina;
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].stamina += recoveryStamina;
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().keeper[0].stamina += recoveryStamina;
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].stamina += recoveryStamina;

            GameObject.Find("ManagementSeasonTracker").GetComponent<ManagementSeasonTracker>().OpenPostTrainingMenu();
            GameObject.Find("ManagementTeamTraining").GetComponent<ManagementTeamTraining>().UpdateSliderOnPostTrainingPage();
        }
        else if (isKeeper &&
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().keeper[0].stamina >= staminaCost )
        {
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().keeper[0].stamina += staminaCost;
           
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().keeper[0].currentDExperience += dodgeExp;
           
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().keeper[0].currentBExperience += blockExp;

            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].stamina += recoveryStamina;
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].stamina += recoveryStamina;
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].stamina += recoveryStamina;
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[0].stamina += recoveryStamina;
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[1].stamina += recoveryStamina;
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].stamina += recoveryStamina;

            GameObject.Find("ManagementSeasonTracker").GetComponent<ManagementSeasonTracker>().OpenPostTrainingMenu();
            GameObject.Find("ManagementTeamTraining").GetComponent<ManagementTeamTraining>().UpdateSliderOnPostTrainingPage();
        }
        else if (isSeeker &&
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].stamina >= -staminaCost)
        {
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].stamina += staminaCost;

            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].currentDExperience += dodgeExp;

            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].currentSpExperience += speedExp;

            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].currentSExperience += sightExp;
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].currentRExperience += reachExp;
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].currentGExperience += grabExp;

            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].stamina += recoveryStamina;
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].stamina += recoveryStamina;
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].stamina += recoveryStamina;
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[0].stamina += recoveryStamina;
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[1].stamina += recoveryStamina;
            GameObject.Find("Players_Team").GetComponent<SeasonTeam>().keeper[0].stamina += recoveryStamina;

            GameObject.Find("ManagementSeasonTracker").GetComponent<ManagementSeasonTracker>().OpenPostTrainingMenu();
            GameObject.Find("ManagementTeamTraining").GetComponent<ManagementTeamTraining>().UpdateSliderOnPostTrainingPage();
        }

        CheckStaminaLimits();
    }

    public void CheckStaminaLimits()
    {
        if (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].stamina > 100) GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].stamina = 100;
        if (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].stamina > 100) GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].stamina = 100;
        if (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].stamina > 100) GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].stamina = 100;
        if (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[0].stamina > 100) GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[0].stamina = 100;
        if (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[1].stamina > 100) GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[1].stamina = 100;
        if (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().keeper[0].stamina > 100) GameObject.Find("Players_Team").GetComponent<SeasonTeam>().keeper[0].stamina = 100;
        if (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].stamina > 100) GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].stamina = 100;

        if (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].stamina < 0) GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].stamina = 0;
        if (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].stamina < 0) GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].stamina = 0;
        if (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].stamina < 0) GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].stamina = 0;
        if (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[0].stamina < 0) GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[0].stamina = 0;
        if (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[1].stamina < 0) GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[1].stamina = 0;
        if (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().keeper[0].stamina < 0) GameObject.Find("Players_Team").GetComponent<SeasonTeam>().keeper[0].stamina = 0;
        if (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].stamina < 0) GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].stamina = 0;
    }
}
