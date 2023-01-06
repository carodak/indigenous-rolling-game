using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMover : MonoBehaviour, IInteractable
{
    [SerializeField] private Animator leftDoor = null;
    [SerializeField] private Animator rightDoor = null;
    [SerializeField] private bool openTrigger = true;

    public void DistInteract(Transform interactorTransform){
        if (openTrigger){
            OpenDoor();
        }
        else {
            //CloseDoor();
        }
    }

    public void CloseInteract(Transform interactorTransform){

    }

    private void OpenDoor()
    {
        leftDoor.Play("LeftDoorOpen", 0, 0.0f);
        rightDoor.Play("RightDoorOpen", 0, 0.0f);
        openTrigger = false;
        SoundManager.PlaySound(SoundManager.Sound.DoorOpened, transform.position);
    }

    private void CloseDoor()
    {
        leftDoor.Play("LeftDoorClose", 0, 0.0f);
        rightDoor.Play("RightDoorClose", 0, 0.0f);
        openTrigger = true;
    }

    public string GetInteractText()
    {
        return "Open/Close Door";
    }
}
