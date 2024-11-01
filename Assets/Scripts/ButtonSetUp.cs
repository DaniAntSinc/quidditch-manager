using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonSetUp : MonoBehaviour
{
    public GameObject teamImage;
    public TMP_Text teamName;
    public int teamNumber;
    GameManager gameManager;

    private void Start()
    {
        gameManager = GameObject.Find("Main Camera").GetComponent<GameManager>();
    }

    public void OnClickOfButton()
    {
        if (!gameManager.visitorSelected)
            AddVisitorTeam();
        else
            AddHomeTeam();
    }

    public void AddVisitorTeam()
    {
        gameManager.visitorInt = teamNumber;
        gameManager.SetUpVisitor();
    }
    public void AddHomeTeam()
    {
        gameManager.homeInt = teamNumber;
        gameManager.SetUpHome();
    }
}
