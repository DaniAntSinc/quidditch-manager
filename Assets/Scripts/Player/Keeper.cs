using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keeper : Player
{
    public int dodge;
    public int block;
    public int salary;
    public void CalculateSalary()
    {
        AgeMatrix();
        salary = Mathf.RoundToInt(((dodge * 50) + (block * 425) + 40000) * ageMultiplier);
    }
}
