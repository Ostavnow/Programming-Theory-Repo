// INHERITANCE
public class Sphere : Shape
{
    // POLYMORPHISM
    public override void UpdatePanelInfo()
    {
        nameShapeText.text = "Sphere Name: " + NameShape;
        shapeColorText.text = "Sphere Color: " + CurrentShapeColor.ToString();
    }
}
