using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CodeMonkey.Utils;
using System.Linq;
using TMPro;

public class WindowGraph : MonoBehaviour
{
    [SerializeField] private Sprite circleSprite;
    public TMP_Text maxUI, minUI, middleMax, middleMin;
    private RectTransform graphContainer;
    int maxValue;

    public GameObject gameManager;
    List<int> valueList = new List<int>() { };
    public void ToggleMomentum()
    {
        graphContainer = transform.Find("GraphContainer").GetComponent<RectTransform>();
        if (valueList.Count > 0)
            valueList.Clear();
        for (int i = 0; i < gameManager.GetComponent<GameManager>().valueListMaco.Count; i++)
        {
            valueList.Add(gameManager.GetComponent<GameManager>().valueListMaco[i]);
        }
        ShowGraph(valueList);
    }

    public void DestroyAllChildren()
    {
        valueList.Clear();
    }

    private GameObject CreateCircle(Vector2 anchoredPosition)
    {
        GameObject gameObject = new GameObject("circle", typeof(Image));
        gameObject.transform.SetParent(graphContainer, false);
        gameObject.GetComponent<Image>().sprite = circleSprite;
        RectTransform rectTransform = gameObject.GetComponent<RectTransform>();
        rectTransform.anchoredPosition = anchoredPosition;
        rectTransform.sizeDelta = new Vector2(11, 11);
        rectTransform.anchorMin = new Vector2(0, 0);
        rectTransform.anchorMax = new Vector2(0, 0);
        return gameObject;
    }

    private void ShowGraph(List<int> valueList)
    {
        if(valueList.Max()> -valueList.Min())
            maxValue = valueList.Max();
        if (valueList.Max() < -valueList.Min())
            maxValue = -valueList.Min();

        float graphHeight = graphContainer.sizeDelta.y;
        float yMaximum = maxValue;
        float combined = yMaximum * 2;
        maxUI.text = maxValue.ToString();
        minUI.text = (-maxValue).ToString();

        middleMax.text = (maxValue/2).ToString();
        middleMin.text = (-maxValue/2).ToString();
        //sizeBetweenEachPoint on the graph

       float xSize = graphContainer.sizeDelta.y / valueList.Count;

        GameObject lastCircleGameObject = null;

        for (int i = 0; i < valueList.Count; i++)
        {
            float xPosition = i * xSize;

            float yPosition = ((valueList[i] + yMaximum) / combined) * graphHeight;
            GameObject circleGameObject = CreateCircle(new Vector2(xPosition, yPosition));
            if (lastCircleGameObject != null) {
                CreateDotConnection(lastCircleGameObject.GetComponent<RectTransform>().anchoredPosition, circleGameObject.GetComponent<RectTransform>().anchoredPosition);
            }
            lastCircleGameObject = circleGameObject;
        }
    }

    private void CreateDotConnection(Vector2 dotA, Vector2 dotB)
    { 
        GameObject gameObject = new GameObject("dotConnection", typeof(Image));
        gameObject.transform.SetParent(graphContainer, false);
        gameObject.GetComponent<Image>().color = new Color(1, 1, 1, 0.5f);
        RectTransform rectTransform = gameObject.GetComponent<RectTransform>();
        Vector2 dir = (dotB - dotA).normalized;
        float distance = Vector2.Distance(dotA, dotB);
        rectTransform.anchorMin = new Vector2(0, 0);
        rectTransform.anchorMax = new Vector2(0, 0);
        rectTransform.sizeDelta = new Vector2(distance, 3);
        rectTransform.anchoredPosition = dotA + dir * distance * 0.5f;
        rectTransform.localEulerAngles = new Vector3(0, 0, UtilsClass.GetAngleFromVectorFloat(dir));
    }
}
