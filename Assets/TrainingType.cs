using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainingType : MonoBehaviour
{
    public bool isTeam, isChaser, isBeater, isKeeper, isSeeker;
    public int staminaCost;
    public int dodgeExp, intExp, passExp, shotExp, speedExp, tackleExp, locateExp, blockExp, sightExp, reachExp, grabExp;
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
