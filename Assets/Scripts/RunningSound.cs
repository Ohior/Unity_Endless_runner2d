using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunningSound : MonoBehaviour
{
    AudioSource audioSource;
    bool isPlaying;
    bool togglePlaying;
    Runner runner;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        runner = GameObject.Find("Runner").GetComponent<Runner>();
        isPlaying = true;
        audioSource.Play();
    }

    // Update is called once per frame
    // void Update()
    // {
    //     if(isGrounded())
    //     {
    //         isPlaying = true;
    //         audioSource.Play();
    //     }
    //     if(isPlaying){
    //         audioSource.Play();

    //     }
    // }
    private bool isGrounded()
    {
        //Return true or false
        return transform.Find("GroundCheck").GetComponent<GroundCheck>().is_grounded;
    }
}
