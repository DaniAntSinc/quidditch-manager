using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keepers : MonoBehaviour
{
    public bool keeper1Stunned, keeper2Stunned;
    float keeper1cooldown = 8, keeper2cooldown = 8;
    GameManager gameManager;

    private void Start()
    {
        gameManager = GameObject.Find("Main Camera").GetComponent<GameManager>();
    }

    private void Update()
    {
        if (keeper1Stunned)
        {
            gameManager.visitorKeepericon.SetActive(false);
            keeper1cooldown -= Time.deltaTime * gameManager.gameSpeedMultiplier;
            if (keeper1cooldown <= 0)
            {
                keeper1cooldown = Random.Range(8, 15);
                gameManager.visitorKeepericon.SetActive(true);
                keeper1Stunned = false;
            }
        }
        if (keeper2Stunned)
        {
            gameManager.homeKeepericon.SetActive(false);
            keeper2cooldown -= Time.deltaTime * gameManager.gameSpeedMultiplier;
            if (keeper2cooldown <= 0)
            {
                keeper2cooldown = Random.Range(8, 15);
                gameManager.homeKeepericon.SetActive(true);
                keeper2Stunned = false;
            }
        }
    }
}
