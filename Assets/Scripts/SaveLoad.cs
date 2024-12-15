using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoad : MonoBehaviour
{
    public bool teamCreated;
    public string playerTeamName;
    public void ClearTeam()
    {
        teamCreated = false;

     //   if(GameObject.Find("Players_Team") != null)
          //  Destroy(GameObject.Find("Players_Team"));
    }

    public void SaveTeam()
    {
        PlayerPrefs.SetString("PlayerTeamName", playerTeamName);
    }

    public void LoadTeam()
    {
        if (!teamCreated)
            return;
        else
        {
            PlayerPrefs.GetString("PlayerTeamName");
        }
    }
}
