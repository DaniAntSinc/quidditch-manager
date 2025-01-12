using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chaser : Player
{
    public int dodge;
    public int intercept;
    public int pass;
    public int shooting;
    public int speed;
    public int tackle;
    public int salary;

    public int currentDExperience;
    public int DExperienceCap;
    public int currentIExperience;
    public int IExperienceCap;
    public int currentPExperience;
    public int PExperienceCap;
    public int currentSExperience;
    public int SExperienceCap;
    public int currentSpExperience;
    public int SpExperienceCap;
    public int currentTExperience;
    public int TExperienceCap;
    public void CalculateSalary()
    {
        {
            AgeMatrix();
            salary = Mathf.RoundToInt(((dodge * 28) + (intercept * 50) + (pass * 60) + (shooting * 68) + (speed * 64) + (tackle * 58) + 20000) * ageMultiplier);
        }
    }
    public void EvaluateExpNeeded()
    {
        DExperienceCap = 100 + dodge;
        IExperienceCap = 100 + intercept;
        PExperienceCap = 100 + pass;
        SExperienceCap = 100 + shooting;
        SpExperienceCap = 100 + speed;
        TExperienceCap = 100 + tackle;
    }

    public void CheckIfOverflow()
    {
        //Negative
        if (currentDExperience <= 0)
        {
            dodge -= 1;
            currentDExperience = (DExperienceCap + currentDExperience);
        }
        if (currentIExperience <= 0)
        {
            intercept -= 1;
            currentIExperience = (IExperienceCap + currentIExperience);
        }
        if (currentPExperience <= 0)
        {
            pass -= 1;
            currentPExperience = (PExperienceCap + currentPExperience);
        }
        if (currentSExperience <= 0)
        {
            shooting -= 1;
            currentSExperience = (SExperienceCap + currentSExperience);
        }
        if (currentSpExperience <= 0)
        {
            speed -= 1;
            currentSpExperience = (SpExperienceCap + currentSpExperience);
        }
        if (currentTExperience <= 0)
        {
            tackle -= 1;
            currentTExperience = (TExperienceCap + currentTExperience);
        }
        //Positive
        if (currentDExperience >= DExperienceCap)
        {
            dodge += 1;
            currentDExperience -= DExperienceCap;
        }
        if (currentIExperience >= IExperienceCap)
        {
            intercept += 1;
            currentIExperience -= IExperienceCap;
        }
        if (currentPExperience >= PExperienceCap)
        {
            pass += 1;
            currentPExperience -= PExperienceCap;
        }
        if (currentSExperience >= SExperienceCap)
        {
            shooting += 1;
            currentSExperience -= SExperienceCap;
        }
        if (currentSpExperience >= SpExperienceCap)
        {
            speed += 1;
            currentSpExperience -= SpExperienceCap;
        }
        if (currentTExperience >= TExperienceCap)
        {
            tackle += 1;
            currentTExperience -= TExperienceCap;
        }
        EvaluateExpNeeded();
    }
}
