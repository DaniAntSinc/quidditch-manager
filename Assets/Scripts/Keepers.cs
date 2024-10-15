using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keepers : MonoBehaviour
{
    public bool keeper1Stunned, keeper2Stunned;
    float keeper1cooldown = 8, keeper2cooldown = 8;

    private void Update()
    {
        if (keeper1Stunned)
        {
            keeper1cooldown -= Time.deltaTime;
            if (keeper1cooldown <= 0)
            {
                keeper1cooldown = Random.Range(6, 14);
                keeper1Stunned = false;
            }
        }
        if (keeper2Stunned)
        {
            keeper2cooldown -= Time.deltaTime;
            if (keeper2cooldown <= 0)
            {
                keeper2cooldown = Random.Range(6, 14);
                keeper2Stunned = false;
            }
        }
    }
}
