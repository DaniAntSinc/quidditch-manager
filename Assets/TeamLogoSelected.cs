using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeamLogoSelected : MonoBehaviour
{
    public int logoNumInList;
    public void LogoSelected()
    {
        GameObject.Find("Management").GetComponent<Management>().logoNumSelected = logoNumInList;
        GameObject.Find("Management").GetComponent<Management>().logoSelectedButton.SetActive(true);
        GameObject.Find("Management").GetComponent<Management>().ClearLogoSelection();
        this.transform.GetChild(1).gameObject.SetActive(true);
    }
}
