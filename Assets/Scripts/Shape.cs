using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    protected string shapeName;
    protected string shapeColor;

    public string Name
    {   
        get { return shapeName; } //ENCAPSULATION
        set { shapeName = value; }  
    }

    public string Color
    {
        get { return shapeColor; } //ENCAPSULATION
        set { shapeName = value; }
    }

    public virtual void DisplayText()
    {
        Debug.Log("These are lights."); //POLYMORPHISM
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
