﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
   // private BoxCollider2D bc2d;
    private Rigidbody2D rb2d;
    [Range(1, 5)]
    public int resistencia;

    private void OnCollisionEnter2D(Collision2D collision)
    {
       // bc2d = GetComponent<BoxCollider2D>();
        rb2d = GetComponent<Rigidbody2D>();
        resistencia = resistencia - 1;
        // Debug.Log(resistencia); 
        if (resistencia <= 0)
        {
           // bc2d.enabled = false;
            rb2d.bodyType = RigidbodyType2D.Dynamic;
            
        }
    }
}
