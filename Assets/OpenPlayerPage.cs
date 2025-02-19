using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        }
        else if (GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Beater>() != null)
        {
            beaterSubMenu.SetActive(true);
        }
        else if (GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Keeper>() != null)
        {
            keeperSubMenu.SetActive(true);
        }
        else if (GameObject.Find("Players_Team").transform.GetChild(childCount).GetComponent<Seeker>() != null)
        {
            seekerSubMenu.SetActive(true);
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
