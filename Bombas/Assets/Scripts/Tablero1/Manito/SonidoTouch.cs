using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Ubica en la imagen del cambas position, se pude usar para generar sonido al ser tocado el objeto
public class SonidoTouch : MonoBehaviour
{
    private AudioSource tocar;
    private bool miAudio;
    void Start()
    {
        tocar = GetComponent<AudioSource>();
        miAudio = true;
    }

    // Update is called once per frame
    private void OnMouseDown()
    {
        ElSonido();
    }
    void ElSonido()
    {
        if (miAudio)
        {
            tocar.Play();
            miAudio = false;
        }

    }
}
