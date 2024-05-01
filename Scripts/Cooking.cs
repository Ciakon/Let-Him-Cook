using System.Collections;
using System.Collections.Generic;
using System.Net;
using Microsoft.Unity.VisualStudio.Editor;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Cooking : MonoBehaviour
{
    public GameObject AllIngredients;
    public GameObject LevelManager;
    private List<GameObject> DishesCooked = new List<GameObject>(); // stop user from cooking same dish twice.
    private float timer = 0;
    private float MaxTimer = 0;

    private void Start() {
        MaxTimer = GetComponent<DishUI>().MaxTimer;
    }
    public void CreateDish() {
        List <GameObject> Ingredients = GetIngredients();

        List <GameObject> AllDishes = new List <GameObject>();

        // Find all dishes ingredients can make

        if (Ingredients.Count < 1) {
            return;
        }

        foreach (GameObject Ingredient in Ingredients) {

            List <GameObject> Dishes = Ingredient.GetComponent<Ingredient>().IngredientIn;

            foreach (GameObject Dish in Dishes) {
                AllDishes.Add(Dish);
            }
        }

        

        List <GameObject> PossibleDishes = new List <GameObject>();
        // Find the dishes, where all ingredients exist

        foreach (GameObject Dish in AllDishes) {
            List <GameObject> RequiredIngredients = Dish.GetComponent<Dish>().RequiredIngredients;

            int NumberOfIngredients = RequiredIngredients.Count;
            int IngredientsFulfilled = 0;

            foreach (GameObject Ingredient in Ingredients) {
                
                if (RequiredIngredients.Contains(Ingredient)) {
                    IngredientsFulfilled++;
                }
            }

            if (IngredientsFulfilled == NumberOfIngredients) {
                PossibleDishes.Add(Dish);
            }
        }

        // No dishes possible

        if (PossibleDishes.Count < 1) {
            return;
        }

        GameObject BestDish = null;
        foreach (GameObject Dish in PossibleDishes) {

            if (BestDish == null) {
                BestDish = Dish;
                continue;
            }

            int CurrentNutritionalValue = Dish.GetComponent<Dish>().NutritionalValue;
            int BestNutrionnalValue = BestDish.GetComponent<Dish>().NutritionalValue;

            if (CurrentNutritionalValue > BestNutrionnalValue) {
                BestDish = Dish;
            }
        }

        foreach (GameObject cookedDish in DishesCooked)
        {
            if (BestDish == cookedDish){
                return;
            }
        }

        DishesCooked.Add(BestDish);

        // old code
        // // Find used ingredients
        // List <GameObject> IngredientsInDish = BestDish.GetComponent<Dish>().RequiredIngredients;
        // List <GameObject> UsedIngredients = new();
        // List <GameObject> UnusedIngredients = new();

        // foreach (GameObject Ingredient in Ingredients) {
        //     if (IngredientsInDish.Contains(Ingredient)) {
        //         UsedIngredients.Add(Ingredient);
        //     }
        //     else {
        //         UnusedIngredients.Add(Ingredient);
        //     }
        // }

        
        //--------------------------------------
        // // Remove ingredients and add the dish
        // foreach (GameObject Ingredient in UsedIngredients) {
        //     Transform transform = Ingredient.GetComponent<Ingredient>().transform;
        //     transform.position = Vector3.up * 50;
        // }
        //

        //BestDish.transform.position = FinishedDishPosition;
        //--------------------------------------

        // Return ingredients to table

        for (int i = 0; i < AllIngredients.transform.childCount; i++)
        {
            GameObject ingredient = AllIngredients.transform.GetChild(i).gameObject;

            ingredient.GetComponent<Ingredient>().ResetPosition();
        }

        // Show dish ui screen
        Sprite DishImage = BestDish.GetComponent<SpriteRenderer>().sprite;
        int NutritionalValue = BestDish.GetComponent<Dish>().NutritionalValue;
        int Stars = NutritionalValueToStars(NutritionalValue);
        string DishName = BestDish.name;

        gameObject.GetComponent<DishUI>().ShowUI(DishName, DishImage, Stars);

        int NV = BestDish.GetComponent<Dish>().NutritionalValue;
        LevelManager.GetComponent<LevelManager>().UpdateUserScore(NV);

        timer = MaxTimer;
    }

    // Keep track of ingredients going on and off the cooker.
	List <GameObject> currentCollisions = new List <GameObject>();
    
    private void OnTriggerEnter2D(Collider2D other) {
        currentCollisions.Add (other.gameObject);
    }
    private void OnTriggerExit2D(Collider2D other) {
        currentCollisions.Remove (other.gameObject);
    }
    List <GameObject> GetIngredients()
    {
        List <GameObject> Ingredients = new List <GameObject>();

        foreach (GameObject collision in currentCollisions) {
            if (collision.tag == "Ingredient") {
                Ingredients.Add(collision);
            }
        }
        return Ingredients;
    }

    private int NutritionalValueToStars(int NV)
    {
        int stars = 1;
        if (NV >= 11)
        {
            stars = 2;
        }
        if (NV >= 14)
        {
            stars = 3;
        }
        if (NV >= 20)
        {
            stars = 4;
        }
        if (NV >= 22)
        {
            stars = 5;
        }

        return stars;
    }

    private void Update() {
        if (timer < 0)
        {
            LevelManager.GetComponent<LevelManager>().CompareScores();
            timer = 0;
        }
        if (timer > 0)
            timer -= Time.deltaTime;
        }
}