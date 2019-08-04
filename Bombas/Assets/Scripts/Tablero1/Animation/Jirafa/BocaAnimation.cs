using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Aplico a la cabeza de mi personaje Jirafa///
public class BocaAnimation : MonoBehaviour
{
    private bool abrir;
    private Animator animator;
    private AudioSource miAudio;

    private void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        miAudio = GetComponent<AudioSource>();
        abrir = true;
    }

    private void Update()
    {
        if (abrir && Puntos.logros==2)      //dice Yeah cuando obtengo 2 Puntos
        {
            animator.Play("abrir");
            miAudio.Play();
            abrir = false;
        }
                  

    }
}
