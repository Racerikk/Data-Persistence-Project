using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonBehaviour : MonoBehaviour
{
    public void StartGame()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            DataManager.instance.playerName = GameObject.Find("PlayerNameText").GetComponent<TextMeshProUGUI>().text;
        }
        if(GameObject.Find("PlayerNameText").GetComponent<TextMeshProUGUI>().text != "")
        {
            SceneManager.LoadScene(1);
        }
    }

    public void CloseGame()
    {
        DataManager.instance.SaveDataMethod();
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); 
#endif
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void WipeScoreboard()
    {
        DataManager.instance.highestScorerName = null;
        DataManager.instance.highScore = 0;
    }
}
