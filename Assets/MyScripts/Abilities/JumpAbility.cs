using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpAbility : MonoBehaviour, IAbility
{
    [SerializeField] private GameObject PlayerGO;
    [SerializeField] private int jumpForce;
    private int jumpsLeft = 2;

    public void Use(){
        if (jumpsLeft <= 0) return;
        PlayerGO.transform.GetChild(0).GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce);
        jumpsLeft -= 1;
        SoundManager.PlaySound(SoundManager.Sound.PlayerJump, PlayerGO.transform.position);
        
    }

    public void resetJumps(){
        jumpsLeft = 2;
    }
}
