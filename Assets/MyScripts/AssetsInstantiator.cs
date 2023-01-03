using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssetsInstantiator : MonoBehaviour
{
    private static AssetsInstantiator _instance;

    public static AssetsInstantiator instance {
        get {
            if (_instance == null) _instance = (Instantiate(Resources.Load("AssetsInstantiator")) as GameObject).GetComponent<AssetsInstantiator>();
            return _instance;
        }
    }

    public Transform pfNPCText;

    public SoundAudioClip[] soundAudioClipArray;
    [System.Serializable]
    public class SoundAudioClip {
        public SoundManager.Sound sound;
        public AudioClip audioClip;
    }
}
