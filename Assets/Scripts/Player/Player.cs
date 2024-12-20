using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //0 = hogwarts, 1 = british isles, 2 = world cup
    public int division;
    public string Name;
    public int age;
    public float ageMultiplier;
    public bool isFreeAgent;

    public Hat hat;
    public Body body;
    public Gloves gloves;
    public Glasses glasses;
    public Broom broom;

    public void AgeMatrix()
    {
        switch (age)
        {
            case 17:
                ageMultiplier = 0.75f;
                break;
            case 18:
                ageMultiplier = 0.7825f;
                break;
            case 19:
                ageMultiplier = 0.8075f;
                break;
            case 20:
                ageMultiplier = 0.8375f;
                break;
            case 21:
                ageMultiplier = 0.8725f;
                break;
            case 22:
                ageMultiplier = 0.9125f;
                break;
            case 23:
                ageMultiplier = 0.9725f;
                break;
            case 24:
                ageMultiplier = 1.0325f;
                break;
            case 25:
                ageMultiplier = 1.1125f;
                break;
            case 26:
                ageMultiplier = 1.2125f;
                break;
            case 27:
                ageMultiplier = 1.3125f;
                break;
            case 28:
                ageMultiplier = 1.4f;
                break;
            case 29:
                ageMultiplier = 1.3525f;
                break;
            case 30:
                ageMultiplier = 1.2925f;
                break;
            case 31:
                ageMultiplier = 1.2325f;
                break;
            case 32:
                ageMultiplier = 1.1525f;
                break;
            case 33:
                ageMultiplier = 1.0725f;
                break;
            case 34:
                ageMultiplier = .9925f;
                break;
            case 35:
                ageMultiplier = 0.8925f;
                break;
            case 36:
                ageMultiplier = 0.7925f;
                break;
            case 37:
                ageMultiplier = 0.7675f;
                break;
            case 38:
                ageMultiplier = 0.7425f;
                break;
            case 39:
                ageMultiplier = 0.6925f;
                break;
        }
    }
}
