using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TipAmount : MonoBehaviour
{
    float total;
    float percent;
    public TotalCost cost;
    public Dropdown dropdown;
    public TMP_Text tipText;

    void Update()
    {
        percent = dropdown.retPercent();
        total = cost.retInit();
        tipDisplay();
    }

    public float calcTip()
    {
        return total * percent;
    }

    void tipDisplay()
    {
        float roundTip = Mathf.Round(calcTip() * 100f) * .01f;
        string tip = roundTip.ToString();
        tipText.SetText(tip);
    }
}
