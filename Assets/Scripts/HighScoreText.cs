using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreText : MonoBehaviour
{
    [SerializeField] Text highScoreText;
    private void Awake()
    {
        if(DataManager.instance.highestScorerName != null && DataManager.instance.highScore != 0)
        {
            highScoreText.text = "High Score: " + DataManager.instance.highestScorerName + " : " + DataManager.instance.highScore;
        }
        else
        {
            highScoreText.text = "No High Score yet";
        }
        
    }
}
