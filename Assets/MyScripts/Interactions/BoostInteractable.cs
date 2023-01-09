using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BoostInteractable : MonoBehaviour, IInteractable
{
    [SerializeField] UnityEvent onPlayerCollision;
    [SerializeField] private string interactText;
    public void DistInteract(Transform interactorTransform){
    }

    public void CloseInteract(Transform interactorTransform){
        Debug.Log("Inside Boost interactable");
        onPlayerCollision.Invoke();
        Destroy(gameObject);
    }

    public string GetInteractText(){
        return interactText;
    }
}
