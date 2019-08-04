using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Lo aplico a mi panel Lost!!

public class LostBoca : MonoBehaviour
{
    private bool abrir;
    private Animator animator;
    private AudioSource miAudio;

    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        miAudio = GetComponent<AudioSource>();
        abrir = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (abrir)      //dice Yeah cuando obtengo dos Puntos
        {
            animator.Play("abrir");
            miAudio.Play();
            abrir = false;
        }
    }
}
