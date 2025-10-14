using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayoffMenu : MonoBehaviour
{
    public GameObject GameModeMenuGO, PlayoffMenuGO;
    public void ClosePlayoffs()
    {
        GameModeMenuGO.SetActive(true);
        PlayoffMenuGO.SetActive(false);
    }
}
