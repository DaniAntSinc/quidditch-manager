using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beater : Player
{
    public int locateSpeed;
    public int dodge;
    public int salary;
    public int currentLSExperience;
    public int LSExperienceCap;

    int proRatedSalary;
    public void CalculateSalary()
    {
        AgeMatrix();
        salary = Mathf.RoundToInt(((locateSpeed * 250) + (dodge * 28) + 32000) * ageMultiplier);
        proRatedSalary = Mathf.RoundToInt((((locateSpeed * 250) + (dodge * 28) + 32000) * ageMultiplier) / ((111 - GameObject.Find("ManagementSeasonTracker").GetComponent<ManagementSeasonTracker>().dayOfSeason) / 111));
    }

    public void EvaluateExpNeeded()
    {
        LSExperienceCap = 100 + locateSpeed;
    }

    public void CheckIfOverflow()
    {
        if (currentLSExperience <= 0)
        {
            locateSpeed -= 1;
            currentLSExperience = (LSExperienceCap + currentLSExperience);
            EvaluateExpNeeded();
        }

        if (currentLSExperience >= LSExperienceCap)
        {
            locateSpeed += 1;
            currentLSExperience -= LSExperienceCap;
            EvaluateExpNeeded();
        }
    }
}
