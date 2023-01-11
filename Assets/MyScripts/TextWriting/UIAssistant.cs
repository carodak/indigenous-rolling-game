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
        TextWriter.AddWriter_Static(messageText, "The great spirit Gitchi Manitou gave our people the Algonquin responsibility to care for the land and water. All things animate or inanimate were created by Gitchi Manitou, therefore we shall always be a part of his spiritual essence. The spirits will grant you access to their power and guide you on your quest to find our identity.", 0.025f, true);
    }
}
