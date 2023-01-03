using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextWriter : MonoBehaviour
{

    private static TextWriter instance;

    private List<TextWriterSingle> textWriterSingleList;

    private void Awake(){
        instance = this;
        textWriterSingleList = new List<TextWriterSingle>();
    }

    public static void AddWriter_Static(TMP_Text uiText, string textToWrite, float speedChar, bool invisibleChars){
        instance.AddWriter(uiText, textToWrite, speedChar, invisibleChars);
    }

    public void AddWriter(TMP_Text uiText, string textToWrite, float speedChar, bool invisibleChars){
        textWriterSingleList.Add(new TextWriterSingle(uiText, textToWrite, speedChar, invisibleChars));
    }

    private void Update(){
        //Debug.Log(textWriterSingleList.Count);
        for (int i=0; i<textWriterSingleList.Count; i++){
            bool destroyInstance = textWriterSingleList[i].Update();
            if (destroyInstance){
                textWriterSingleList.RemoveAt(i);
                i--;
            }
        }
    }


/*
    Single TextWriter instance
*/
    public class TextWriterSingle {

        private TMP_Text uiText;
        private string textToWrite;
        private float speedChar;
        private int charIndex;
        private float timer;
        private bool invisibleChars;
    
        public TextWriterSingle(TMP_Text uiText, string textToWrite, float speedChar, bool invisibleChars){
            this.uiText = uiText;
            this.textToWrite = textToWrite;
            this.speedChar = speedChar;
            this.invisibleChars = invisibleChars;
            charIndex = 0;
        }
        public bool Update(){
            timer -= Time.deltaTime;
            while (timer <= 0f){
                timer += speedChar;
                charIndex++;
                string text = textToWrite.Substring(0, charIndex);
                if (invisibleChars){
                    text += "<color=#00000000>" + textToWrite.Substring(charIndex) + "</color>";
                }
                uiText.text = text;

                if (charIndex >= textToWrite.Length){
                    return true;
                }
            }
            return false;
        }
    }
}
