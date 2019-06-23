﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//**** Aplicamos a nuestras burbujas **********

public class Burbujas : MonoBehaviour
{
    //private Rigidbody2D rb2d;
   // private BoxCollider2D bc2d;
    private CircleCollider2D cc2d;
    private CircleCollider2D cc2dItem;
    private Rigidbody2D rb2dItem;
    public GameObject ItemInterior;
   // private Transform transItem;     
    [Range(1, 5)]
    public int resistencia;
       

    private void OnCollisionEnter2D(Collision2D collision)
    {
        cc2d = GetComponent<CircleCollider2D>();
        rb2dItem = ItemInterior.GetComponent<Rigidbody2D>();
        cc2dItem = ItemInterior.GetComponent<CircleCollider2D>();
        resistencia = resistencia - 1;
       // Debug.Log(resistencia); 
        if (resistencia <= 0)
        {
            cc2d.enabled = false;
           // rb2dItem.bodyType = RigidbodyType2D.Dynamic;    //caen objetos
            cc2dItem.isTrigger = true;
            //transItem.position = new Vector3(0, 0, 0);              
            rb2dItem.drag = 1;
            
        }
    }
        

}
