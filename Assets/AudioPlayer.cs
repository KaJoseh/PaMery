using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    public AudioClip Audio;
    private AudioSource sMotor;
    GameManager gm;
    bool canplay = true;


    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
        sMotor = GetComponent<AudioSource>();
        sMotor.clip = Audio;
    }

    // Update is called once per frame
    void Update()
    {
        if (gm.Jugando.Equals(1) && canplay)
        {
            canplay = false;
            sMotor.Play();
        }
        else if(gm.Jugando.Equals(0) || gm.Jugando.Equals(2))
        {
            sMotor.Stop();
            canplay = true;
        }
            
    }
}
