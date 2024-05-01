using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dish : MonoBehaviour
{
    public List <GameObject> RequiredIngredients;
    public int NutritionalValue = 0;


    // Start is called before the first frame update
    void Start()
    {

        if (NutritionalValue > 0) {
            return;
        }

        NutritionalValue = 0;
        
        foreach (GameObject Ingredient in RequiredIngredients) {
            
            int IngredientValue = Ingredient.GetComponent<Ingredient>().NutritionalValue;

            NutritionalValue += IngredientValue;
            
        }
    }

}
