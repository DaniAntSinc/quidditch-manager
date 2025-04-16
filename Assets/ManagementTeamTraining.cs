using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ManagementTeamTraining : MonoBehaviour
{
    public TMP_Text chaserName1, chaserName2, chaserName3, beaterName1, beaterName2, keeperName, seekerName;

    public TMP_Text chaserInterceptMin, chaserPassMin, chaserShootingMin, chaserSpeedMin, chaserTackleMin, chaserDodgeMin;
    public TMP_Text chaserInterceptMax, chaserPassMax, chaserShootingMax, chaserSpeedMax, chaserTackleMax, chaserDodgeMax;

    public TMP_Text chaser2InterceptMin, chaser2PassMin, chaser2ShootingMin, chaser2SpeedMin, chaser2TackleMin, chaser2DodgeMin;
    public TMP_Text chaser2InterceptMax, chaser2PassMax, chaser2ShootingMax, chaser2SpeedMax, chaser2TackleMax, chaser2DodgeMax;

    public TMP_Text chaser3InterceptMin, chaser3PassMin, chaser3ShootingMin, chaser3SpeedMin, chaser3TackleMin, chaser3DodgeMin;
    public TMP_Text chaser3InterceptMax, chaser3PassMax, chaser3ShootingMax, chaser3SpeedMax, chaser3TackleMax, chaser3DodgeMax;

    public TMP_Text beater1locateSpeedMin, beater1dodgeMin;
    public TMP_Text beater1locateSpeedMax, beater1dodgeMax;

    public TMP_Text beater2locateSpeedMin, beater2dodgeMin;
    public TMP_Text beater2locateSpeedMax, beater2dodgeMax;

    public TMP_Text keeperblockMin, keeperdodgeMin;
    public TMP_Text keeperblockMax, keeperdodgeMax;

    public TMP_Text seekerSightMin, seekerSpeedMin, seekerReachMin, seekerGrabMin, seekerDodgeMin;
    public TMP_Text seekerSightMax, seekerSpeedMax, seekerReachMax, seekerGrabMax, seekerDodgeMax;
    //sliders too

    public Slider chaser1Stamina, chaser1Intercept, chaser1Pass, chaser1Shooting, chaser1Speed, chaser1Tackle, chaser1Dodge;
    public Slider chaser2Stamina, chaser2Intercept, chaser2Pass, chaser2Shooting, chaser2Speed, chaser2Tackle, chaser2Dodge;
    public Slider chaser3Stamina, chaser3Intercept, chaser3Pass, chaser3Shooting, chaser3Speed, chaser3Tackle, chaser3Dodge;

    public Slider beater1Stamina, beater1locateSpeed, beater1Dodge;
    public Slider beater2Stamina, beater2locateSpeed, beater2Dodge;

    public Slider keeper1Stamina, keeper1block, keeper1dodge;

    public Slider seekerStamina, seekerSight, seekerSpeed, seekerReach, seekerGrab, seekerDodge;

    //Training Page
    //Text Fields
    public TMP_Text trainingChaser1, trainingChaser2, trainingChaser3, trainingBeater1, trainingBeater2, trainingKeeper, trainingSeeker;
    public Slider chaser1Stam, chaser2Stam, chaser3Stam, beater1Stam, beater2Stam, keeperStam, seekerStam;

    public TrainingType[] trainingTypeList;

    public void OpenTrainingPage()
    {
        trainingChaser1.text = GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].Name;
        trainingChaser2.text = GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].Name;
        trainingChaser3.text = GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].Name;
        trainingBeater1.text = GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[0].Name;
        trainingBeater2.text = GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[1].Name;
        trainingKeeper.text = GameObject.Find("Players_Team").GetComponent<SeasonTeam>().keeper[0].Name;
        trainingSeeker.text = GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].Name;

        chaser1Stam.value = ((float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].stamina / 100);
        chaser2Stam.value = ((float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].stamina / 100);
        chaser3Stam.value = ((float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].stamina / 100);

        beater1Stam.value = ((float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[0].stamina / 100);
        beater2Stam.value = ((float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[1].stamina / 100);

        keeperStam.value = ((float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().keeper[0].stamina / 100);

        seekerStam.value = ((float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].stamina / 100);

        chaser1Stam.transform.GetChild(1).GetChild(0).GetComponent<Image>().color = Color.Lerp(Color.red, Color.green, ((float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].stamina / 100));
        chaser2Stam.transform.GetChild(1).GetChild(0).GetComponent<Image>().color = Color.Lerp(Color.red, Color.green, ((float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].stamina / 100));
        chaser3Stam.transform.GetChild(1).GetChild(0).GetComponent<Image>().color = Color.Lerp(Color.red, Color.green, ((float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].stamina / 100));

        beater1Stam.transform.GetChild(1).GetChild(0).GetComponent<Image>().color = Color.Lerp(Color.red, Color.green, ((float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[0].stamina / 100));
        beater2Stam.transform.GetChild(1).GetChild(0).GetComponent<Image>().color = Color.Lerp(Color.red, Color.green, ((float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[1].stamina / 100));

        keeperStam.transform.GetChild(1).GetChild(0).GetComponent<Image>().color = Color.Lerp(Color.red, Color.green, ((float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().keeper[0].stamina / 100));
        seekerStam.transform.GetChild(1).GetChild(0).GetComponent<Image>().color = Color.Lerp(Color.red, Color.green, ((float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].stamina / 100));

        //Prep All Training Types
        for (int i = 0; i < trainingTypeList.Length; i++)
        {
            trainingTypeList[i].PrepList();
        }
    }
    public void UpdateSliderOnPostTrainingPage()
    {
        //update min/max
        chaserName1.text = GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].Name;
        chaserName2.text = GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].Name;
        chaserName3.text = GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].Name;
        beaterName1.text = GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[0].Name;
        beaterName1.text = GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[1].Name;
        keeperName.text = GameObject.Find("Players_Team").GetComponent<SeasonTeam>().keeper[0].Name;
        seekerName.text = GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].Name;

        chaserInterceptMin.text = GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].intercept.ToString();
        chaserInterceptMax.text = (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].intercept + 1).ToString();
        chaserPassMin.text = GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].pass.ToString();
        chaserPassMax.text = (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].pass + 1).ToString();
        chaserShootingMin.text = GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].shooting.ToString();
        chaserShootingMax.text = (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].shooting + 1).ToString();
        chaserSpeedMin.text = GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].speed.ToString();
        chaserSpeedMax.text = (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].speed + 1).ToString();
        chaserTackleMin.text = GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].tackle.ToString();
        chaserTackleMax.text = (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].tackle + 1).ToString();
        chaserDodgeMin.text = GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].dodge.ToString();
        chaserDodgeMin.text = (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].dodge + 1).ToString();

        chaser2InterceptMin.text = GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].intercept.ToString();
        chaser2InterceptMax.text = (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].intercept + 1).ToString();
        chaser2PassMin.text = GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].pass.ToString();
        chaser2PassMax.text = (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].pass + 1).ToString();
        chaser2ShootingMin.text = GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].shooting.ToString();
        chaser2ShootingMax.text = (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].shooting + 1).ToString();
        chaser2SpeedMin.text = GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].speed.ToString();
        chaser2SpeedMax.text = (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].speed + 1).ToString();
        chaser2TackleMin.text = GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].tackle.ToString();
        chaser2TackleMax.text = (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].tackle + 1).ToString();
        chaser2DodgeMin.text = GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].dodge.ToString();
        chaser2DodgeMin.text = (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].dodge + 1).ToString();

        chaser3InterceptMin.text = GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].intercept.ToString();
        chaser3InterceptMax.text = (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].intercept + 1).ToString();
        chaser3PassMin.text = GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].pass.ToString();
        chaser3PassMax.text = (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].pass + 1).ToString();
        chaser3ShootingMin.text = GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].shooting.ToString();
        chaser3ShootingMax.text = (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].shooting + 1).ToString();
        chaser3SpeedMin.text = GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].speed.ToString();
        chaser3SpeedMax.text = (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].speed + 1).ToString();
        chaser3TackleMin.text = GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].tackle.ToString();
        chaser3TackleMax.text = (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].tackle + 1).ToString();
        chaser3DodgeMin.text = GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].dodge.ToString();
        chaser3DodgeMin.text = (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].dodge + 1).ToString();

        beater1locateSpeedMin.text = GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[0].locateSpeed.ToString();
        beater1locateSpeedMax.text = (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[0].locateSpeed + 1).ToString();
        beater1dodgeMin.text = GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[0].dodge.ToString();
        beater1dodgeMax.text = (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[0].dodge + 1).ToString();

        beater2locateSpeedMin.text = GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[1].locateSpeed.ToString();
        beater2locateSpeedMax.text = (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[1].locateSpeed + 1).ToString();
        beater2dodgeMin.text = GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[1].dodge.ToString();
        beater2dodgeMax.text = (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[1].dodge + 1).ToString();

        keeperblockMin.text = GameObject.Find("Players_Team").GetComponent<SeasonTeam>().keeper[0].block.ToString();
        keeperblockMax.text = (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().keeper[0].block + 1).ToString();
        keeperdodgeMin.text = GameObject.Find("Players_Team").GetComponent<SeasonTeam>().keeper[0].dodge.ToString();
        keeperdodgeMax.text = (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().keeper[0].dodge + 1).ToString();

        seekerSightMin.text = GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].sight.ToString();
        seekerSightMax.text = (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].sight + 1).ToString();
        seekerSpeedMin.text = GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].speed.ToString();
        seekerSpeedMax.text = (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].speed + 1).ToString();
        seekerReachMin.text = GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].reach.ToString();
        seekerReachMax.text = (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].reach + 1).ToString();
        seekerGrabMin.text = GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].grab.ToString();
        seekerGrabMax.text = (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].grab + 1).ToString();
        seekerDodgeMin.text = GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].dodge.ToString();
        seekerDodgeMax.text = (GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].dodge + 1).ToString();

        //update sliders

        chaser1Stamina.value = ((float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].stamina / 100);
        chaser2Stamina.value = ((float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].stamina / 100);
        chaser3Stamina.value = ((float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].stamina / 100);

        chaser1Intercept.value = ((float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].currentIExperience / (float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].IExperienceCap);
        chaser2Intercept.value = ((float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].currentIExperience / (float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].IExperienceCap);
        chaser3Intercept.value = ((float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].currentIExperience / (float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].IExperienceCap);
        chaser1Pass.value = ((float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].currentPExperience / (float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].PExperienceCap);
        chaser2Pass.value = ((float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].currentPExperience / (float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].PExperienceCap);
        chaser3Pass.value = ((float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].currentPExperience / (float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].PExperienceCap);
        chaser1Shooting.value = ((float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].currentSExperience / (float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].SExperienceCap);
        chaser2Shooting.value = ((float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].currentSExperience / (float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].SExperienceCap);
        chaser3Shooting.value = ((float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].currentSExperience / (float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].SExperienceCap);
        chaser1Speed.value = ((float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].currentSpExperience / (float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].SpExperienceCap);
        chaser2Speed.value = ((float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].currentSpExperience / (float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].SpExperienceCap);
        chaser3Speed.value = ((float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].currentSpExperience / (float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].SpExperienceCap);
        chaser1Tackle.value = ((float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].currentTExperience / (float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].TExperienceCap);
        chaser2Tackle.value = ((float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].currentTExperience / (float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].TExperienceCap);
        chaser3Tackle.value = ((float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].currentTExperience / (float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].TExperienceCap);

        chaser1Dodge.value = ((float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].currentDExperience / (float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[0].DExperienceCap);
        chaser2Dodge.value = ((float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].currentDExperience / (float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[1].DExperienceCap);
        chaser3Dodge.value = ((float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].currentDExperience / (float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().chasers[2].DExperienceCap);

        beater1Stamina.value = ((float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[0].stamina / 100);
        beater1locateSpeed.value = ((float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[0].currentLSExperience / (float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[0].LSExperienceCap);
        beater1Dodge.value = ((float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[0].currentDExperience / (float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[0].DExperienceCap);

        beater2Stamina.value = ((float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[1].stamina / 100);
        beater2locateSpeed.value = ((float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[1].currentLSExperience / (float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[1].LSExperienceCap);
        beater2Dodge.value = ((float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[1].currentDExperience / (float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().beaters[1].DExperienceCap);

        keeper1Stamina.value = ((float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().keeper[0].stamina / 100);
        keeper1block.value = ((float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().keeper[0].currentBExperience / (float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().keeper[0].BExperienceCap);
        keeper1dodge.value = ((float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().keeper[0].currentDExperience / (float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().keeper[0].DExperienceCap);

        seekerStamina.value = ((float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].stamina / 100);
        seekerSight.value = ((float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].currentSExperience / (float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].SExperienceCap);
        seekerSpeed.value = ((float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].currentSpExperience / (float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].SpExperienceCap);
        seekerReach.value = ((float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].currentRExperience / (float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].RExperienceCap);
        seekerGrab.value = ((float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].currentGExperience / (float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].GExperienceCap);
        seekerDodge.value = ((float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].currentDExperience / (float)GameObject.Find("Players_Team").GetComponent<SeasonTeam>().seeker[0].DExperienceCap);

        //save exp
        GameObject.Find("SaveLoad").GetComponent<SaveLoad>().SaveLineUp();
        GameObject.Find("SaveLoad").GetComponent<SaveLoad>().SaveExperience();
        GameObject.Find("SaveLoad").GetComponent<SaveLoad>().SaveStamina();
    }
}
