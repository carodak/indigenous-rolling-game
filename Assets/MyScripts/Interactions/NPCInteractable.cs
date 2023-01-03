using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCInteractable : MonoBehaviour, IInteractable
{
    [SerializeField] private string interactText;
    [SerializeField] private AudioClip dialogueAudioClip;
    private bool hasInteracted = false;

    public void DistInteract(Transform interactorTransform){
        if (!hasInteracted){
            NPCTextCreator.Create(transform.transform, new Vector3(-.3f, 1.25f, 0f), interactText);
            SoundManager.PlayDialog(dialogueAudioClip);
            hasInteracted = true;
        }
    }

    public void CloseInteract(Transform interactorTransform){
        
    }

    public string GetInteractText(){
        return interactText;
    }

    
}
