using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape
{
    public override void UpdatePanelInfo()
    {
        nameShapeText.text = "Sphere Name: " + NameShape;
        shapeColorText.text = "Sphere Color: " + CurrentShapeColor.ToString();
    }
}
