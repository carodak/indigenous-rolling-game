using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GroundInteractable : MonoBehaviour, IInteractable
{
    [SerializeField] UnityEvent onPlayerCollision;
    [SerializeField] private string interactText;

    public void Interact(Transform interactorTransform){
        onPlayerCollision.Invoke();
    }

    public string GetInteractText(){
        return interactText;
    }
}
