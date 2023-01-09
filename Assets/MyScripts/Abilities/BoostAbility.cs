using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostAbility : MonoBehaviour, IAbility
{
    [SerializeField] private GameObject PlayerGO;
    [SerializeField] private float boostAmount;
    private float maxBoost = 1f;
    private float boostLeft = 1f;

    public void RefillBoost(){
        boostLeft = 1f;
    }

    public float GetBoostLeft(){
        return boostLeft;
    }

    public void Use(){
        if (boostLeft <= 0) return;
        //rb.AddForce(Vector3.up * jumpForce);
        //playerRB.AddRelativeForce(Vector3.forward * 1/boostAmount);
        PlayerGO.transform.GetChild(0).GetComponent<Rigidbody>().AddForce(boostAmount * Vector3.up, ForceMode.Impulse);
        //playerGO.GetComponent<Rigidbody>().AddRelativeForce(playerGO.transform.forward * boostAmount, ForceMode.Acceleration);
        boostLeft = boostLeft - Time.deltaTime;
        //Debug.Log("Boost left: " + boostLeft);
        SoundManager.PlaySound(SoundManager.Sound.PlayerBoost, PlayerGO.transform.position);
    }
}
