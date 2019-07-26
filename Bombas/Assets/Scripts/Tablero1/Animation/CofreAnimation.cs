using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//**** aplicamos a nuestro cofre *****///
public class CofreAnimation : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {           
         animator.SetTrigger("tocando");
      
    }
}
