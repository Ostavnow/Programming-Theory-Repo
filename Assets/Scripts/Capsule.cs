// INHERITANCE
public class Capsule : Shape
{
    // POLYMORPHISM
    public override void UpdatePanelInfo()
    {
        nameShapeText.text = "Capsule Name: " + NameShape;
        shapeColorText.text = "Capsule Color: " + CurrentShapeColor.ToString();
    }
}
