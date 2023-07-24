using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPress : MonoBehaviour
{
    public TotalCost cost;

    void Start()
    {

    }

    public void Button1()
    {
        cost.typeCost(1);
    }

    public void Button2()
    {
        cost.typeCost(2);
    }

    public void Button3()
    {
        cost.typeCost(3);
    }

    public void Button4()
    {
        cost.typeCost(4);
    }

    public void Button5()
    {
        cost.typeCost(5);
    }

    public void Button6()
    {
        cost.typeCost(6);
    }

    public void Button7()
    {
        cost.typeCost(7);
    }

    public void Button8()
    {
        cost.typeCost(8);
    }

    public void Button9()
    {
        cost.typeCost(9);
    }

    public void Button0()
    {
        cost.typeCost(0);
    }

    public void point()
    {
        cost.typePoint();
    }

    public void clear()
    {
        cost.typeClear();
    }
}
