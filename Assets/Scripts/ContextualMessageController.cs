using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ContextualMessageController : MonoBehaviour
{
    private CanvasGroup canvasGroup;
    private TMP_Text messageText;

    // Start is called before the first frame update
    void Start()
    {
        canvasGroup = GetComponent<CanvasGroup>();
        messageText = GetComponent<TMP_Text>();

        canvasGroup.alpha = 0;
    }

    private void ShowMessage(string message, float duration)
    {
        messageText.text = message;
    }
    //// Update is called once per frame
    //void Update()
    //{
        
    //}
}
