using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GroundInteractable : MonoBehaviour, IInteractable
{
    [SerializeField] UnityEvent onPlayerCollision;
    [SerializeField] private string interactText;
    [SerializeField] private GameObject playerGO;
    public float distToGround = 1f;

    public void Interact(Transform interactorTransform){
        if(GroundCheck())
        {
            onPlayerCollision.Invoke();
            Debug.Log("Player is on the ground!!!");
        }
    }

    public bool GroundCheck()
    {
        RaycastHit hit;
        return Physics.Raycast(playerGO.transform.position, Vector3.down, out hit, distToGround + 0.1f);
    }

    public string GetInteractText(){
        return interactText;
    }
}
