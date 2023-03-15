using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    public AudioClip trackAudioClip;
    public AudioSource trackAudioSource;

    void Start()
    {
        trackAudioClip = Resources.Load<AudioClip>("Track");
        trackAudioSource = GetComponent<AudioSource>();
        trackAudioSource.Play();
    }
}
