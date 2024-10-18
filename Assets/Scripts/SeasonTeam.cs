using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeasonTeam : MonoBehaviour
{
    public string team;
    public int win;
    public int loss;
    public int score;

    public string[] chaserNames;
    public int[] chaserDodge;
    public int[] chaserIntercept;
    public int[] chaserPass;
    public int[] chaserShooting;
    public int[] chaserSpeed;
    public int[] chaserTackle;

    public string[] beaterNames;
    public int[] beaterLocateSpeed;
    public int[] beaterDodge;

    public string keeperName;
    public int keeperDodge;
    public int keeperBlock;

    public string seekerName;
    public int seekerSight;
    public int seekerSpeed;
    public int seekerReach;
    public int seekerGrab;

    public float teamSun, teamRain, teamFog, teamSnow;
}
