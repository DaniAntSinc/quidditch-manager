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
    public void CalculateSalary()
    {
        AgeMatrix();
        salary = Mathf.RoundToInt(((dodge * 50) + (block * 425) + 40000) * ageMultiplier);
    }

    public void EvaluateExpNeeded()
    {
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
