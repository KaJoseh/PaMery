using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioBackGround : MonoBehaviour
{
    public AudioClip Audio;
    private AudioSource audio;

    void Start()
    {
        audio = GetComponent<AudioSource>();
        audio.clip = Audio;
        audio.Play();
    }

   
}
