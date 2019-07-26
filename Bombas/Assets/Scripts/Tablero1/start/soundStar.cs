using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundStar : MonoBehaviour
{
    AudioSource audioStar;
    [Range(0.0f,3.0f)]
    public float DelaySound;
    // Start is called before the first frame update
    void Start()
    {
        audioStar = GetComponent<AudioSource>();
        Invoke("PlayAudio", DelaySound);
    }

    // Update is called once per frame
    void PlayAudio()
    {

        audioStar.Play();
    }
}
