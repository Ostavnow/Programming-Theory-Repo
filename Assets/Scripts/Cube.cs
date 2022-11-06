// INHERITANCE
public class Cube : Shape
{
    // POLYMORPHISM
   public override void UpdatePanelInfo()
    {
        nameShapeText.text = "Cube Name: " + NameShape;
        shapeColorText.text = "Cube Color: " + CurrentShapeColor.ToString();
    }
}
