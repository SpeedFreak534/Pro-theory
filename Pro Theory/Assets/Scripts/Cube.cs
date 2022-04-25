using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{
    private string shapeName;

    private void Start()
    {
        shapeName = "myCube";
    }

    public override void DisplayText()
    {
        Debug.Log(shapeName + " shape clicked!");
    }
}
