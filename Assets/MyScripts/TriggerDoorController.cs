using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoorController : MonoBehaviour
{
    [SerializeField] private Animator leftDoor = null;
    [SerializeField] private Animator rightDoor = null;
    [SerializeField] private bool openTrigger = true;
    
    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player") && openTrigger){
                leftDoor.Play("LeftDoorOpen", 0, 0.0f);
                rightDoor.Play("RightDoorOpen", 0, 0.0f);
                openTrigger = false;
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.CompareTag("Player") && !openTrigger){
            leftDoor.Play("LeftDoorClose", 0, 0.0f);
            rightDoor.Play("RightDoorClose", 0, 0.0f);
            openTrigger = true;
        }  
    }
}
