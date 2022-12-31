using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SoundManager
{
    public enum Sound{
        PlayerJump,
        PlatformLevel0
    }


    public static void PlaySound(Sound sound){
        GameObject soudGameObject = new GameObject("Sound");
        AudioSource audioSource = soudGameObject.AddComponent<AudioSource>();
        //audioSource.PlayOneShot(AssetsInstantiator.instance.playerJump);
    }

    private static AudioClip GetAudioClip(Sound sound){
        
    }
}
