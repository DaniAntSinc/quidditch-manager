using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beater : Player
{
    public int locateSpeed;
    public int dodge;
    public int salary;
    public void CalculateSalary()
    {
        AgeMatrix();
        salary = Mathf.RoundToInt(((locateSpeed * 250) + (dodge * 28) + 32000) * ageMultiplier);
    }
}
