using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public static MenuManager instance;

    [SerializeField] TextMeshProUGUI playerNameInput;
    
    private void Start()
    {
        instance = this;
        playerNameInput.text = DataManager.instance.playerName;
        Debug.Log("Name: "+playerNameInput.text);
    }
}