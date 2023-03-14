using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenSphere : Shape //INHERITANCE
{
    public Color shapeColor;

public Color Color
{
    get { return shapeColor; }
    set { shapeColor = value; } //ENCAPSULATION

}

public override void DisplayText() //POLYMORPHISM
    {
    Debug.Log("GO!");
}
}

