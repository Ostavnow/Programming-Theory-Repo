using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UserControll : MonoBehaviour
{
    private TMP_InputField inputField;
    private Shape currentShape;
    private TMP_Text currentShapeClass;
    void Start()
    {
        inputField = FindObjectOfType<TMP_InputField>();
        currentShapeClass = GameObject.Find("Canvas/Panel info/Class").GetComponent<TMP_Text>();
    }

    void Update()
    {
       if(Input.GetMouseButtonDown(0))
       {
            OnHandle();
       } 
    }
    private void OnHandle()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit) && hit.transform.CompareTag("Shape"))
        {
            currentShape = hit.transform.GetComponent<Shape>();
            if(currentShape is Cube cube)
            {
                cube.UpdatePanelInfo();
                currentShapeClass.text = "Class: " + cube.GetType();
            }
            else if(currentShape is Sphere sphere)
            {
                sphere.UpdatePanelInfo();
                currentShapeClass.text = "Class: " + sphere.GetType();
            }
            else if(currentShape is Capsule capsule)
            {
                capsule.UpdatePanelInfo();
                currentShapeClass.text = "Class: " + capsule.GetType();
            }
            else
            {
                currentShape.UpdatePanelInfo();
                currentShapeClass.text = "Class: Cube" + currentShape.GetType();
            }
            Debug.Log("Выбран объект" + currentShape.name);
        }
    }
    public void SetName()
    {
        if(currentShape != null && inputField.text.Length > 0)
        {
        currentShape.NameShape = inputField.text;
        inputField.text = null;
        }
        else if(currentShape != null && inputField.text.Length == 0)
        {
            Debug.LogWarning("You haven't entered anything");
        }
    }
    public void SetColorRed()
    {
        if(currentShape != null)
        {
        currentShape.CurrentShapeColor = Shape.ShapeColor.Red;
        }
    }
    public void SetColorGreen()
    {
        if(currentShape != null)
        {
        currentShape.CurrentShapeColor = Shape.ShapeColor.Green;
        }
    }
    public void SetColorBlue()
    {
        if(currentShape != null)
        {
        currentShape.CurrentShapeColor = Shape.ShapeColor.Blue;
        }
    }
}
