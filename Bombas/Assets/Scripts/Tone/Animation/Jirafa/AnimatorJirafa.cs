﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorJirafa : MonoBehaviour
{
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
   public void saltar()
    {
        animator.Play("saltar");
    }
}
