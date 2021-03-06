﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//aplicamos a nuestro obstaculos///
//cambiamos las gamas de colores!!

public class GamaColores : MonoBehaviour
{
    public Golpes obstaculo;
    private SpriteRenderer sr;  
    [Range(0,5)]
    private int rTotal;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        rTotal = obstaculo.resistencia;
        animator = GetComponent<Animator>();
       // sr.color = new Color(1f, 1f, 1f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        rTotal = obstaculo.resistencia;
        animator.SetInteger("resistencia", rTotal);

        if (rTotal < 5)                            //GamaColores
        {
            sr.color = new Color32(255,225,227,255);    //FFE1E3  1er         
        }
        if (rTotal == 3)
        {
            sr.color = new Color32(253, 159, 162,255);     //FD9FA2 2do        
        }
        if (rTotal == 2)
        {
            sr.color = new Color32(255, 108, 114,255);    //FF6C72 3ro
        }
        if (rTotal == 1)
        {               
            sr.color = new Color32(253, 0, 11,255);     //FD000B 4to
        }           
        
    }
}
