using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayVoice : MonoBehaviour
{
    public AudioSource voice;
    void Start()
    {
         
    }

    public void touch_play()
    {
        if(!voice.isPlaying)
        {
            voice.Play();
        }
    }

    public void stop_play()
    {
        if(voice.isPlaying)
        {
            voice.Stop();
        }
    }

}
