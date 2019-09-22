using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Terremoto : MonoBehaviour
{

    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void boom()
    {
        animator.Play("terremoto");
    }

    public void boomX2()
    {
        animator.Play("terremotoX2");
    }
}
