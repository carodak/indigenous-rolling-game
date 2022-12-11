using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCInteractable : MonoBehaviour, IInteractable
{
    [SerializeField] private string interactText;
    public void Interact(Transform interactorTransform){
        NPCTextCreator.Create(transform.transform, new Vector3(-.3f, 1.25f, 0f), "Hey, you!");
    }

    public string GetInteractText(){
        return interactText;
    }
}
