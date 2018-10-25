using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BongoTrigger : MonoBehaviour


{
    public AudioClip bongo;    // Add your Audi Clip Here;


    void Start()
    {
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = bongo;
    }

    void OnTriggerEnter()  //Plays Sound Whenever trigger detected
    {
        GetComponent<AudioSource>().Play();
    }


}
