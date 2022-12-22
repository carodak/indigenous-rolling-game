using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractor : MonoBehaviour
{

    public void Update(){
        float interactDistRange = 12f;
        float interactCloseRange = 1f;

        Collider[] colliderCloseArray = Physics.OverlapSphere(transform.position, interactCloseRange);
        Collider[] colliderDistArray = Physics.OverlapSphere(transform.position, interactDistRange);
   
        foreach (Collider col in colliderDistArray){
            if(col.TryGetComponent(out IInteractable interactable)){
                interactable.DistInteract(transform);
            }
        }

        foreach (Collider col in colliderCloseArray){
            if(col.TryGetComponent(out IInteractable interactable)){
                interactable.CloseInteract(transform);
            }
        }
   
    }

    /*
    private void OnTriggerExit(Collider col) {
        if(col.TryGetComponent(out DoorMover doorInteractable)){
            doorInteractable.Interact(transform);
        }
    }

    private void Update() {
    }
    */
}
