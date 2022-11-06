using UnityEngine;
using TMPro;
public class Shape : MonoBehaviour
{
    // ENCAPSULATION
    private string nameShape;
    public string NameShape
    {
        get{return nameShape;}
        set
        {
            if(value.Length < 20)
            {
                nameShape = value;
                Debug.Log("name " + nameShape + " assigned successfully");
            }
            else
            {
                Debug.LogError("the name is too long. The name must not exceed more than 20 characters");
            }
            UpdatePanelInfo();
        }
    }
    public enum ShapeColor{Unidentified,Red,Green,Blue}
    // ENCAPSULATION
    protected ShapeColor currentShapeColor;
    public ShapeColor CurrentShapeColor
    {
        get{return currentShapeColor;}
        set
        {
            if(value == ShapeColor.Red)
            {
                material.color = Color.red;
                currentShapeColor = value;
            }
            else if(value == ShapeColor.Green)
            {
                material.color = Color.green;
                currentShapeColor = value;
            }
            else if(value == ShapeColor.Blue)
            {
                material.color = Color.blue;
                currentShapeColor = value;
            }
            UpdatePanelInfo();
        }
    }
    protected TMP_Text nameShapeText;
    protected TMP_Text shapeColorText;
    private Material material;
    void Start()
    {
        material = GetComponent<MeshRenderer>().material;
        nameShapeText = GameObject.Find("Canvas/Panel info/Name").GetComponent<TMP_Text>();
        shapeColorText = GameObject.Find("Canvas/Panel info/Color").GetComponent<TMP_Text>();
    }
    //ABSTRACTION
    public virtual void UpdatePanelInfo()
    {
        nameShapeText.text = "Name: " + NameShape;
        shapeColorText.text = "Color: " + CurrentShapeColor.ToString();
    }
}
