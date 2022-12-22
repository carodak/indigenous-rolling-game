using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIAssistant : MonoBehaviour
{
    private TextMeshPro messageText;
    
    private void Awake(){
        messageText = transform.Find("Message").Find("MessageText").GetComponent<TextMeshPro>();
    }

    private void Start(){
        messageText.SetText("Hello World!");
    }
}
