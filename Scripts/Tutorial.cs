using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class Tutorial : MonoBehaviour
{
    float timer = 0;
    public float TutorialTime = 7;
    public GameObject Darkness;
    public GameObject levelUI;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(true);
        Darkness.SetActive(true);
        levelUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= TutorialTime)
        {
            gameObject.SetActive(false);
            Darkness.SetActive(false);
            levelUI.SetActive(true);
        }
    }
}
