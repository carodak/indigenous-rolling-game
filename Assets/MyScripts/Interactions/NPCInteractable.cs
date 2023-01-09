using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCInteractable : MonoBehaviour, IInteractable
{
    [SerializeField] private string interactText;
    [SerializeField] private AudioClip dialogueAudioClip;
    private bool hasInteracted = false;
    private NPCHeadLookAt nPCHeadLookAt;

    private void Awake() {
        //animator = GetComponent<Animator>();
        nPCHeadLookAt = GetComponent<NPCHeadLookAt>();
    }

    public void DistInteract(Transform interactorTransform){
        if (!hasInteracted){
            NPCTextCreator.Create(transform.transform, new Vector3(1.89f, 4f, -.83f), interactText);
            SoundManager.PlayDialog(dialogueAudioClip, transform.position);
            //float playerHeight = 1.7f;
            //nPCHeadLookAt.LookAtPosition(interactorTransform.position + Vector3.up * playerHeight);
            hasInteracted = true;
        }
    }

    public void CloseInteract(Transform interactorTransform){
        
    }

    public string GetInteractText(){
        return interactText;
    }

    
}
