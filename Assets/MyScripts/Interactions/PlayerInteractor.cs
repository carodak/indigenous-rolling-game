using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractor : MonoBehaviour
{
    private void OnTriggerEnter(Collider col) {
        if(col.TryGetComponent(out IInteractable interactable)){
            interactable.Interact(transform);
        }
    }

    private void OnTriggerExit(Collider col) {
        if(col.TryGetComponent(out DoorMover doorInteractable)){
            doorInteractable.Interact(transform);
        }
    }

    private void OnTriggerStay(Collider col) {
        if(col.TryGetComponent(out IInteractable interactable)){
            interactable.Interact(transform);
        }
    }

    private void Update() {
    }
}
