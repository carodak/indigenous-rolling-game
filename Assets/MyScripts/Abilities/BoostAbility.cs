using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostAbility : MonoBehaviour, IAbility
{
    [SerializeField] private GameObject playerGO;
    [SerializeField] private int boostAmount;
    private int maxBoost = 1000;
    private int boostLeft;

    public void RefillBoost(){
        boostLeft = 1000;
    }

    public void Use(){
        //rb.AddForce(Vector3.up * jumpForce);
        //playerRB.AddRelativeForce(Vector3.forward * 1/boostAmount);
        playerGO.GetComponent<Rigidbody>().AddForce(boostAmount * Vector3.up, ForceMode.Impulse);
        //playerGO.GetComponent<Rigidbody>().AddRelativeForce(playerGO.transform.forward * boostAmount, ForceMode.Acceleration);
        boostLeft -= 1;
    }
}
