using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioSource audioSource;
    bool playSound = false;


    public void ToggleSound()
    {
        if(playSound)
        {
            audioSource.Stop();

            playSound = false;
        }else
        {
            audioSource.Play();
            playSound = true;
        }
    }
}
