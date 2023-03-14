using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowSphere : Shape
{
    public Color shapeColor;

    public Color Color
    {
        get { return shapeColor; }
        set { shapeColor = value; }

    }

    public override void DisplayText()
    {
        Debug.Log("Go faster.");
    }
}

