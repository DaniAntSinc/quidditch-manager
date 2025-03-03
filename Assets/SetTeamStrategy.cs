using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SetTeamStrategy : MonoBehaviour
{
    public TeamStrategy strategy;
    public TMP_Text stratName, stratSummary, dodgeNumStrat, speedNumStrat, interceptNumStrat, passingNumStrat, shootingNumStrat, tackleNumStrat, locateNumStrat, blockNumStrat, sightNumStrat, reachNumStrat, grabNumStrat;

    public void SetUpStrategyTextFields()
    {
        if (strategy == GameObject.Find("Players_Team").GetComponent<SeasonTeam>().teamStrategy)
        {
            this.transform.GetChild(2).GetComponent<Button>().enabled = false;
            this.transform.GetChild(2).GetChild(0).GetComponent<TMP_Text>().color = Color.grey;
        }
        stratName.text = strategy.stratName;
        stratSummary.text = strategy.stratExplanation;
        dodgeNumStrat.text = strategy.dodge.ToString();
        speedNumStrat.text = strategy.speed.ToString();
        interceptNumStrat.text = strategy.intercept.ToString();
        passingNumStrat.text = strategy.passing.ToString();
        shootingNumStrat.text = strategy.shooting.ToString();
        tackleNumStrat.text = strategy.tackle.ToString();
        locateNumStrat.text = strategy.locateSpeed.ToString();
        blockNumStrat.text = strategy.sight.ToString();
        sightNumStrat.text = strategy.sight.ToString();
        reachNumStrat.text = strategy.reach.ToString();
        grabNumStrat.text = strategy.grab.ToString();
        CheckColors();
    }

    public void CheckColors()
    {
        if (strategy.dodge > 0) dodgeNumStrat.color = Color.green;
        if (strategy.dodge < 0) dodgeNumStrat.color = Color.red;

        if (strategy.speed > 0) speedNumStrat.color = Color.green;
        if (strategy.speed < 0) speedNumStrat.color = Color.red;

        if (strategy.intercept > 0) interceptNumStrat.color = Color.green;
        if (strategy.intercept < 0) interceptNumStrat.color = Color.red;

        if (strategy.passing > 0) passingNumStrat.color = Color.green;
        if (strategy.passing < 0) passingNumStrat.color = Color.red;

        if (strategy.shooting > 0) shootingNumStrat.color = Color.green;
        if (strategy.shooting < 0) shootingNumStrat.color = Color.red;

        if (strategy.tackle > 0) tackleNumStrat.color = Color.green;
        if (strategy.tackle < 0) tackleNumStrat.color = Color.red;

        if (strategy.locateSpeed > 0) locateNumStrat.color = Color.green;
        if (strategy.locateSpeed < 0) locateNumStrat.color = Color.red;

        if (strategy.block > 0) blockNumStrat.color = Color.green;
        if (strategy.block < 0) blockNumStrat.color = Color.red;

        if (strategy.sight > 0) sightNumStrat.color = Color.green;
        if (strategy.sight < 0) sightNumStrat.color = Color.red;

        if (strategy.reach > 0) reachNumStrat.color = Color.green;
        if (strategy.reach < 0) reachNumStrat.color = Color.red;

        if (strategy.grab > 0) grabNumStrat.color = Color.green;
        if (strategy.grab < 0) grabNumStrat.color = Color.red;
    }
    public void SetStrategy()
    {
        GameObject.Find("Players_Team").GetComponent<SeasonTeam>().teamStrategy = strategy;
        //save
        GameObject.Find("SaveLoad").GetComponent<SaveLoad>().SaveTeamStrategy(strategy.strategyNum);
        //turn all buttons on
        for (int i = 0; i < GameObject.Find("Management").GetComponent<Management>().teamStrategies.Length; i++)
        {
            GameObject.Find("Management").GetComponent<Management>().teamStrategies[i].transform.GetChild(2).GetComponent<Button>().enabled = true;
            GameObject.Find("Management").GetComponent<Management>().teamStrategies[i].transform.GetChild(2).GetChild(0).GetComponent<TMP_Text>().color = Color.white;
        }
        //turn this one off
        this.transform.GetChild(2).GetComponent<Button>().enabled = false;
        this.transform.GetChild(2).GetChild(0).GetComponent<TMP_Text>().color = Color.grey;
    }
}
