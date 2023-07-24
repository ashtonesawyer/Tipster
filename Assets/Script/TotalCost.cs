using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TotalCost : MonoBehaviour
{

    float totalCost;
    float roundCost;
    float initCost = 0.00f;
    float pointCount = 1;
    public TMP_Text costDisplay;
    public TMP_Text initDisplay;
    public TipAmount tip;
    bool point = false;

    void Update()
    {
        ChangeCost();
        ChangeTotal();
    }

    void ChangeTotal()
    {
        totalCost = initCost + tip.calcTip();
        roundCost = Mathf.Round(totalCost * 100f) * .01f;
        costDisplay.SetText(roundCost.ToString());
    }

    void ChangeCost()
    {
        initDisplay.SetText(initCost.ToString());
    }

    public void typeCost(float button)
    {
        if (!point)
        {
            initCost *= 10;
            initCost += button;
        }
        else
        {
            pointCount *= .1f;
            button *= pointCount;
            initCost += button;
        }
    }

    public float retInit()
    {
        return initCost;
    }

    public void typePoint()
    {
        point = true;
    }

    public void typeClear()
    {
        initCost = 0f;
        pointCount = 1;
        point = false;
    }
}