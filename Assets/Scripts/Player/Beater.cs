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
    public int currentDExperience;
    public int DExperienceCap;

    public int proRatedSalary;

    public float stamina = 1;
    public void CalculateSalary()
    {
        AgeMatrix();
        salary = Mathf.RoundToInt(((locateSpeed * 250) + (dodge * 28) + 32000) * ageMultiplier);
        float salaryHolder = ((((locateSpeed * 250) + (dodge * 28) + 32000) * ageMultiplier) / 111) * (111 - GameObject.Find("ManagementSeasonTracker").GetComponent<ManagementSeasonTracker>().dayOfSeason);
        proRatedSalary = Mathf.RoundToInt(salaryHolder);
    }

    public void EvaluateExpNeeded()
    {
        DExperienceCap = 100 + dodge;
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
