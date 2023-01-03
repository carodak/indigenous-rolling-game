using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIAssistant : MonoBehaviour
{
    private TMP_Text messageText;
    
    private void Awake(){
        messageText = transform.Find("Message").Find("MessageText").GetComponent<TMP_Text>();
        //Debug.Log("Message Text: ", messageText);
    }

    private void Start(){
        TextWriter.AddWriter_Static(messageText, "Hello World! Lorem Ipsum is simply dummy text of the printing. dsldnlsndjlsndj dsdsd dummy text of the printing. dsldnlsndjlsndj dsdsd dummy text of the printing. dsldnlsndjlsndj dsdsd", 0.05f, true);
    }
}
