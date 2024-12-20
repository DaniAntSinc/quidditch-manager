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
    public void CalculateSalary()
    {
        AgeMatrix();
        salary = Mathf.RoundToInt(((dodge * 50) + (sight * 225) + (speed * 225) + (reach * 450) + (grab * 7500) + 20000) * ageMultiplier);
    }
}
