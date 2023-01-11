using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CutSceneInteractable : MonoBehaviour, IInteractable
{
   [SerializeField] UnityEvent onPlayerCollision;
   [SerializeField] private string interactText;
    public void DistInteract(Transform interactorTransform){
        onPlayerCollision.Invoke();
        Destroy(gameObject);
    }

    public void CloseInteract(Transform interactorTransform){     
    }

    public string GetInteractText(){
        return interactText;
    }
}
