using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : Shape
{
    private string shapeName;

    private void Start()
    {
        shapeName = "myCylinder";
    }

    public override void DisplayText()
    {
        Debug.Log(shapeName + " shape clicked!");
    }
}
