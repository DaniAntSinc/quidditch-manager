using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seeker : Player
{
    public int dodge;
    public int sight;
    public int speed;
    public int reach;
    public int grab;
    public int salary;

    public int currentDExperience;
    public int DExperienceCap;
    public int currentSExperience;
    public int SExperienceCap;
    public int currentSpExperience;
    public int SpExperienceCap;
    public int currentRExperience;
    public int RExperienceCap;
    public int currentGExperience;
    public int GExperienceCap;

    int proRatedSalary;
    public void CalculateSalary()
    {
        AgeMatrix();
        salary = Mathf.RoundToInt(((dodge * 50) + (sight * 225) + (speed * 225) + (reach * 450) + (grab * 7500) + 20000) * ageMultiplier);
        proRatedSalary = Mathf.RoundToInt((((dodge * 50) + (sight * 225) + (speed * 225) + (reach * 450) + (grab * 7500) + 20000) * ageMultiplier) / ((111 - GameObject.Find("ManagementSeasonTracker").GetComponent<ManagementSeasonTracker>().dayOfSeason) / 111));
    }
    public void EvaluateExpNeeded()
    {
        DExperienceCap = 100 + dodge;
        SExperienceCap = 100 + sight;
        SpExperienceCap = 100 + speed;
        RExperienceCap = 100 + reach;
        GExperienceCap = 26 + grab;
    }

    public void CheckIfOverflow()
    {
        //Negative
        if (currentDExperience <= 0)
        {
            dodge -= 1;
            currentDExperience = (DExperienceCap + currentDExperience);
        }
        if (currentSExperience <= 0)
        {
            sight -= 1;
            currentSExperience = (SExperienceCap + currentSExperience);
        }
        if (currentSpExperience <= 0)
        {
            speed -= 1;
            currentSpExperience = (SpExperienceCap + currentSpExperience);
        }
        if (currentRExperience <= 0)
        {
            reach -= 1;
            currentRExperience = (RExperienceCap + currentRExperience);
        }
        if (currentGExperience <= 0)
        {
            grab -= 1;
            currentGExperience = (GExperienceCap + currentGExperience);
        }
        //Positive
        if (currentDExperience >= DExperienceCap)
        {
            dodge += 1;
            currentDExperience -= DExperienceCap;
        }
        if (currentSExperience >= SExperienceCap)
        {
            sight += 1;
            currentSExperience -= SExperienceCap;
        }
        if (currentSpExperience >= SpExperienceCap)
        {
            speed += 1;
            currentSpExperience -= SpExperienceCap;
        }
        if (currentRExperience >= RExperienceCap)
        {
            reach += 1;
            currentRExperience -= RExperienceCap;
        }
        if (currentGExperience >= GExperienceCap)
        {
            grab += 1;
            currentGExperience -= GExperienceCap;
        }
        EvaluateExpNeeded();
    }
}
