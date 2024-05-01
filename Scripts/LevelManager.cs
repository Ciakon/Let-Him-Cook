using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public int level;
    public List<int> levelRequirements;
    public TextMeshProUGUI UserScoreText;
    public TextMeshProUGUI RequiredScoreText;
    public TextMeshProUGUI LevelText;
    // Start is called before the first frame update
    private void Start()
    {
        level = 1;
        UpdateUserScore(0);
        UpdateRequiredScore(levelRequirements[0]);
        UpdateLevel(level);
    }

    public void UpdateLevel(int levelNumber)
    {

        if (levelNumber > levelRequirements.Count)
        {
            LevelText.text = "You win"; 
            RequiredScoreText.text = "";
            return;
        }

        int score = levelRequirements[levelNumber - 1];

        RequiredScoreText.text = score.ToString();
        LevelText.text = "Level: " + levelNumber.ToString();
        UpdateUserScore(0);
    }

    public void UpdateUserScore(int score)
    {
        UserScoreText.text = score.ToString();
    }

    public void UpdateRequiredScore(int score)
    {
        RequiredScoreText.text = score.ToString();
    }

    public void CompareScores()
    {
        int userScore = int.Parse(UserScoreText.text);
        int requredScore = int.Parse(RequiredScoreText.text);

        if (userScore >= requredScore)
        {
            level += 1;
            UpdateLevel(level);
        }
    }
    
}
