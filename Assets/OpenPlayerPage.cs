using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OpenPlayerPage : MonoBehaviour
{
    public int childCount;
    public GameObject chaserSubMenu, beaterSubMenu, seekerSubMenu, keeperSubMenu;
    public void OpenIndividualPage()
    {
        GameObject.Find("Management").GetComponent<Management>().OpenIndividualPage();
        CloseAllSubMenus();
        if (GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>() != null)
        {
            chaserSubMenu.SetActive(true);
            GameObject.Find("LineUpName").GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().Name;
            GameObject.Find("LineUpPosition").GetComponent<TMP_Text>().text = "Chaser";

            //Num
            chaserSubMenu.transform.GetChild(0).GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().intercept.ToString();
            chaserSubMenu.transform.GetChild(1).GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().pass.ToString();
            chaserSubMenu.transform.GetChild(2).GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().shooting.ToString();
            chaserSubMenu.transform.GetChild(3).GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().speed.ToString();
            chaserSubMenu.transform.GetChild(4).GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().tackle.ToString();
            chaserSubMenu.transform.GetChild(5).GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Chaser>().dodge.ToString();
        }
        else if (GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Beater>() != null)
        {
            beaterSubMenu.SetActive(true);
            GameObject.Find("LineUpName").GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Beater>().Name;
            GameObject.Find("LineUpPosition").GetComponent<TMP_Text>().text = "Beater";
            //Num
            beaterSubMenu.transform.GetChild(0).GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Beater>().locateSpeed.ToString();
            beaterSubMenu.transform.GetChild(1).GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Beater>().dodge.ToString();
        }
        else if (GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Keeper>() != null)
        {
            keeperSubMenu.SetActive(true);
            GameObject.Find("LineUpName").GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Keeper>().Name;
            GameObject.Find("LineUpPosition").GetComponent<TMP_Text>().text = "Keeper";
            //Num
            keeperSubMenu.transform.GetChild(0).GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Keeper>().block.ToString();
            keeperSubMenu.transform.GetChild(1).GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Keeper>().dodge.ToString();
        }
        else if (GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Seeker>() != null)
        {
            seekerSubMenu.SetActive(true);
            GameObject.Find("LineUpName").GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Seeker>().Name;
            GameObject.Find("LineUpPosition").GetComponent<TMP_Text>().text = "Seeker";
            //Num
            seekerSubMenu.transform.GetChild(0).GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Seeker>().sight.ToString();
            seekerSubMenu.transform.GetChild(1).GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Seeker>().speed.ToString();
            seekerSubMenu.transform.GetChild(2).GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Seeker>().reach.ToString();
            seekerSubMenu.transform.GetChild(3).GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Seeker>().grab.ToString();
            seekerSubMenu.transform.GetChild(4).GetChild(1).GetComponent<TMP_Text>().text = GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Seeker>().dodge.ToString();
        }
    }

    void CloseAllSubMenus()
    {
        chaserSubMenu.SetActive(false);
        beaterSubMenu.SetActive(false);
        keeperSubMenu.SetActive(false);
        seekerSubMenu.SetActive(false);
    }
}
