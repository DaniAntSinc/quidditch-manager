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
    public void CalculateSalary()
    {
        {
            AgeMatrix();
            salary = Mathf.RoundToInt(((dodge * 28) + (intercept * 50) + (pass * 60) + (shooting * 68) + (speed * 64) + (tackle * 58) + 20000) * ageMultiplier);
        }
    }
}
