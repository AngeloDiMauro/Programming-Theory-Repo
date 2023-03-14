using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenClickHandler : ShapeClickHandler
{

    private void OnMouseDown()
    {
        DisplayShapeInfo(shapeObject.GetComponent<GreenSphere>());
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
