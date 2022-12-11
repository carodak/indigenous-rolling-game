using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NPCTextCreator : MonoBehaviour
{

    public static void Create(Transform parent, Vector3 localPosition, string text){
        Transform NPCTextTransform = Instantiate(AssetsInstantiator.instance.pfNPCText, parent);
        NPCTextTransform.localPosition = localPosition;

        NPCTextTransform.GetComponent<NPCTextCreator>().SetNPCText(text);
        Destroy(NPCTextTransform.gameObject, 6f);
    }

    private TextMeshPro textMeshPro;

    private void Awake() {
        textMeshPro = transform.Find("Text").GetComponent<TextMeshPro>();
    }

    private void Start() {
    }

    private void SetNPCText(string text){
        textMeshPro.SetText(text);
    }
}
