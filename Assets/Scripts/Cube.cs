using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{
   public override void UpdatePanelInfo()
    {
        nameShapeText.text = "Cube Name: " + NameShape;
        shapeColorText.text = "Cube Color: " + CurrentShapeColor.ToString();
    }
}
