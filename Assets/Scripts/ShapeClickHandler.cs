using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ShapeClickHandler : MonoBehaviour
{
    public GameObject shapeObject;
    private Shape shapeScript;

    private void OnMouseDown()
    {
        DisplayShapeInfo(shapeObject.GetComponent<Shape>());
    }

    public void DisplayShapeInfo(Shape shape)
    {
        Debug.Log("Name: " + shape.Name);
        Debug.Log("Color: " + shape.Color); //ABSTRACTION
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == shapeObject)
            {
                shapeScript = hit.collider.gameObject.GetComponent<Shape>();
                shapeScript.DisplayText();
            }
        }
    }
}
