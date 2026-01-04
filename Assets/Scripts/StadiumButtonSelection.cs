using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StadiumButtonSelection : MonoBehaviour
{
    public int itemInStadiumList;
    public GameManager gameManager;
    public TMP_Text stadiumNameField;

    private void Start()
    {
        StartCoroutine("WaitForASecond");
    }

    public void StadiumSelected()
    {
        for (int i = 0; i < gameManager.stadiumGO.Length; i++)
        {
            gameManager.stadiumGO[i].transform.GetChild(1).gameObject.SetActive(false);
        }
        gameManager.stadiumGO[itemInStadiumList].transform.GetChild(1).gameObject.SetActive(true);
        gameManager.stadiumSelected = itemInStadiumList;
        print(gameManager.stadiumList[gameManager.stadiumSelected].stadiumName);

        gameManager.CheckWeather();   
    }

    IEnumerator WaitForASecond()
    {
        yield return new WaitForSeconds(0.3f);

        /*for (int i = 0; i < gameManager.stadiumList.Length; i++)
        {
            print(gameManager.stadiumList[i]);
        }
        */

        // print(gameManager.stadiumList[itemInStadiumList].stadiumName.ToString());
        // stadiumNameField.text = gameManager.stadiumList[itemInStadiumList].stadiumName.ToString();
        stadiumNameField.text = GameObject.Find("Main Camera").GetComponent<GameManager>().stadiumList[itemInStadiumList].stadiumName.ToString();
    }
}
