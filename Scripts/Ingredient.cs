using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ingredient : MonoBehaviour
{
    // Start is called before the first frame update
    // L
    Vector3 mousePosition;
    public List <GameObject> IngredientIn;
    public int NutritionalValue;
    bool isMoving = false;
    //public GameObject table;
    Vector3 DefaultPosition;
    void Start()
    {
        DefaultPosition = transform.position;
    }

    void Update()
    {
        if (isMoving)
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(mousePosition.x, mousePosition.y, transform.position.z);
        }
        
    }

    void OnMouseUp()
    {
        if (isMoving)
            isMoving = false;
        else
            isMoving = true;
    }

    public void ResetPosition()
    {
        transform.position = DefaultPosition;
    }
}
