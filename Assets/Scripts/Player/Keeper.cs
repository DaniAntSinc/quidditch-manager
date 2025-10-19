using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keeper : Player
{
    public int dodge;
    public int block;
    public int salary;

    public int currentBExperience;
    public int BExperienceCap;
    public int currentDExperience;
    public int DExperienceCap;

    public int proRatedSalary;

    public float stamina = 100;
    public void CalculateSalary()
    {
        AgeMatrix();
        salary = Mathf.RoundToInt(((dodge * 50) + (block * 425) + 40000) * ageMultiplier);
        float salaryHolder = (((((dodge * 50) + (block * 425) + 40000) * ageMultiplier) / 111) * (111 - GameObject.Find("ManagementSeasonTracker").GetComponent<ManagementSeasonTracker>().dayOfSeason));
        proRatedSalary = Mathf.RoundToInt(salaryHolder);
    }

    public void EvaluateExpNeeded()
    {
        DExperienceCap = 100 + dodge;
        BExperienceCap = 115 + block;
    }
    public void CheckIfOverflow()
    {
        if (currentBExperience <= 0)
        {
            block -= 1;
            currentBExperience = (BExperienceCap + currentBExperience);
            EvaluateExpNeeded();
        }

        if (currentBExperience >= BExperienceCap)
        {
            block += 1;
            currentBExperience -= BExperienceCap;
            EvaluateExpNeeded();
        }
    }
}
