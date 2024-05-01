using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CookButton : MonoBehaviour
{
    public GameObject Button;

    void OnMouseUp() {
        Button.GetComponentInParent<Cooking>().CreateDish();
    }
}
