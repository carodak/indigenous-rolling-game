using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SoundManager
{
    public enum Sound {
        PlayerJump,
        PlayerBoost,
        PortalReached,
        DoorOpened,
        SceneLevel0

        // Deity moving sound or use PlayAudioClip for that
    }

    public static void PlaySound(Sound sound, Vector3 position){
        GameObject soudGameObject = new GameObject("Sound");
        soudGameObject.transform.position = position;
        AudioSource audioSource = soudGameObject.AddComponent<AudioSource>();
        audioSource.clip = GetAudioClip(sound);
        audioSource.maxDistance = 100f;
        audioSource.spatialBlend = 1f;
        audioSource.rolloffMode = AudioRolloffMode.Linear;
        audioSource.dopplerLevel = 0f;
        audioSource.Play();

        Object.Destroy(soudGameObject, audioSource.clip.length);
    }


    public static void PlaySound(Sound sound){
        GameObject soudGameObject = new GameObject("Sound");
        AudioSource audioSource = soudGameObject.AddComponent<AudioSource>();
        audioSource.PlayOneShot(GetAudioClip(sound));

        Object.Destroy(soudGameObject, audioSource.clip.length);
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

    public static void PlayDialog(AudioClip dialogueAudioClip, Vector3 position){
        GameObject soudGameObject = new GameObject("Sound");
        soudGameObject.transform.position = position;
        AudioSource audioSource = soudGameObject.AddComponent<AudioSource>();
        audioSource.clip = dialogueAudioClip;
        audioSource.maxDistance = 100f;
        audioSource.spatialBlend = 1f;
        audioSource.rolloffMode = AudioRolloffMode.Linear;
        audioSource.dopplerLevel = 0f;
        audioSource.Play();

        Object.Destroy(soudGameObject, audioSource.clip.length);
    }
    
    public static void PlayDialog(AudioClip dialogueAudioClip){
        GameObject soudGameObject = new GameObject("Sound");
        AudioSource audioSource = soudGameObject.AddComponent<AudioSource>();
        audioSource.PlayOneShot(dialogueAudioClip);

        Object.Destroy(soudGameObject, audioSource.clip.length);
    }
}
