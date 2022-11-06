using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : Shape
{
    public override void UpdatePanelInfo()
    {
        nameShapeText.text = "Capsule Name: " + NameShape;
        shapeColorText.text = "Capsule Color: " + CurrentShapeColor.ToString();
    }
}
