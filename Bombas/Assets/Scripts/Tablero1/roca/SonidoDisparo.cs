using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoDisparo : MonoBehaviour
{

    public AudioClip disparo;
    public AudioSource audioData;
    private AudioSource sonido;
    // Start is called before the first frame update
    void Start()
    {
        sonido = GetComponent<AudioSource>();
        audioData = GetComponent<AudioSource>();
    }
       
    // proyectil lanzado objeto lanzado
    private void OnMouseUp()
    {
      //  Debug.Log("Solatado");
        sonido.PlayOneShot(disparo, 1.0F);
        audioData.Stop();
    }

    private void OnMouseDown()
    {
        audioData.Play();
    }
}
