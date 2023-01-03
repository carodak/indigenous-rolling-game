using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpAbility : MonoBehaviour, IAbility
{
    [SerializeField] private Rigidbody playerRB;
    [SerializeField] private int jumpForce;
    private int jumpsLeft = 2;

    public void Use(){
        if (jumpsLeft <= 0) return;
        playerRB.AddForce(Vector3.up * jumpForce);
        jumpsLeft -= 1;
        SoundManager.PlaySound(SoundManager.Sound.PlayerJump);
        
    }

    public void resetJumps(){
        jumpsLeft = 2;
    }
}
