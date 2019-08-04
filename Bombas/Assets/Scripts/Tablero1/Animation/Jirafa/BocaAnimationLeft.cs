using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Aplico a mi personaje ubicado a la izquierda///
//toco crear otra clase debio a la rotacion de la Boca///
public class BocaAnimationLeft : MonoBehaviour
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
        if (abrir && Puntos.logros == 2)      //dice Yeah cuando obtengo 2 Puntos
        {
            animator.Play("abrirLeft");
            miAudio.Play();
            abrir = false;
        }


    }
}
