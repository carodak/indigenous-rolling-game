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
        audioSource.PlayOneShot(GetAudioClip(sound));
    }

    private static AudioClip GetAudioClip(Sound sound){
        foreach (AssetsInstantiator.SoundAudioClip soundAudioClip in AssetsInstantiator.instance.soundAudioClipArray){
            if (soundAudioClip.sound == sound){
                return soundAudioClip.audioClip;
            }
        }
        Debug.LogError("Sound " + sound + " not found!");
        return null;
    }
    
    public static void PlayDialog(AudioClip dialogueAudioClip){
        GameObject soudGameObject = new GameObject("Sound");
        AudioSource audioSource = soudGameObject.AddComponent<AudioSource>();
        audioSource.PlayOneShot(dialogueAudioClip);
    }
}
