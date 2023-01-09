using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NPCTextCreator : MonoBehaviour
{

    public static void Create(Transform parent, Vector3 localPosition, string text){
        Transform NPCTextTransform = Instantiate(AssetsInstantiator.instance.pfNPCText, parent);
        NPCTextTransform.localPosition = localPosition;
        NPCTextTransform.LookAt(NPCTextTransform.position + Camera.main.transform.rotation * Vector3.forward, Camera.main.transform.rotation * Vector3.up);
        
        /*
        Vector3 diff = Camera.main.transform.position - NPCTextTransform.position;
        diff.x = diff.z = 0.0f;
        NPCTextTransform.LookAt( Camera.main.transform.position - diff );
        NPCTextTransform.rotation =(Camera.main.transform.rotation); // Take care about camera rotation
        
        */

        NPCTextTransform.GetComponent<NPCTextCreator>().SetNPCText(text);

        Destroy(NPCTextTransform.gameObject, 20f);
    }

    private TMP_Text textMeshPro;

    private void Awake() {
        textMeshPro = transform.Find("Text").GetComponent<TMP_Text>();
    }

    private void Start() {
    }

    private void SetNPCText(string text){
        textMeshPro.SetText(text);
        TextWriter.AddWriter_Static(textMeshPro, text, .035f, true);
    }
}
