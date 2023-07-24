using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropdown : MonoBehaviour
{
    float Percent;

    public void InputData(int pos)
    {
        if (pos == 0)
        {
            Percent = 0;
        }
        else if (pos == 1)
        {
            Percent = .25f;
        }
        else if (pos == 2)
        {
            Percent = .22f;
        }
        else if (pos == 3)
        {
            Percent = .20f;
        }
        else if (pos == 4)
        {
            Percent = .19f;
        }
        else if (pos == 5)
        {
            Percent = .15f;
        }
    }

    public float retPercent()
    {
        return Percent;
    }

}
