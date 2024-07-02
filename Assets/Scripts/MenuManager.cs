using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[DefaultExecutionOrder(1000)]
public class MenuManager : MonoBehaviour
{
    public static MenuManager instance;

    [SerializeField] TextMeshProUGUI playerNameInput;
    [SerializeField] TextMeshProUGUI alertMessage;
    
    private void Start()
    {
        instance = this;
    }

    public void DisplayAlertMessage(string message)
    {
        if (!alertMessage.gameObject.activeSelf)
        {
            alertMessage.gameObject.SetActive(true);
        }
        alertMessage.text = message;
        StartCoroutine(DisableAfterDelay(alertMessage.gameObject, 2));
    }

    IEnumerator DisableAfterDelay(GameObject target, float delay)
    {
        yield return new WaitForSeconds(delay);
        target.SetActive(false);
    }
}