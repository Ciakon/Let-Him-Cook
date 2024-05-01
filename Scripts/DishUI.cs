using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class DishUI : MonoBehaviour
{
    public TextMeshProUGUI DishNameField;
    public Image DishImage;
    public GameObject UIScreen;
    public GameObject _1Star;
    public GameObject _2Stars;
    public GameObject _3Stars;
    public GameObject _4Stars;
    public GameObject _5Stars;
    float Timer = 0;
    public float MaxTimer = 3;
    bool IsVisible = false;

    private void Start() {
        HideUI();
    }

    private void Update() {
        Timer -= Time.deltaTime;

        if (Timer < 0 && IsVisible) {
            HideUI();
            IsVisible = false;
        }
    }
    public void ShowUI(string DishName, Sprite sprite, int Stars)
    {
        UIScreen.SetActive(true);
        DishNameField.text = DishName;
        DishImage.sprite = sprite;

        if (Stars == 1)
            _1Star.SetActive(true);
        if (Stars == 2)
            _2Stars.SetActive(true);
        if (Stars == 3)
            _3Stars.SetActive(true);
        if (Stars == 4)
            _4Stars.SetActive(true);
        if (Stars == 5)
            _5Stars.SetActive(true);

        IsVisible = true;
        Timer = 3;
    }

    void HideUI()
    {
        UIScreen.SetActive(false);
        _1Star.SetActive(false);
        _2Stars.SetActive(false);
        _3Stars.SetActive(false);
        _4Stars.SetActive(false);
        _5Stars.SetActive(false);
    }

}
