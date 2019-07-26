﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//** Se aplica a nuestros obstaculos ****
public class Obstaculo : MonoBehaviour
{
   // private BoxCollider2D bc2d;
    private Rigidbody2D rb2d;
    private PolygonCollider2D pc2d;
    [Range(0, 5)]
    public int resistencia;
    [Range(0, 10)]
    public int NoPuntos;
    public bool destruir;

    public ClasePadre clasePadre;

    private void Start()
    {
        pc2d = GetComponent<PolygonCollider2D>();
        destruir = false;   // poder de destruir al primer contacto! 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        destruir = clasePadre.estado;
        rb2d = GetComponent<Rigidbody2D>();
        resistencia = resistencia - 1;
        // Debug.Log(resistencia); 
        if (resistencia <= 0 || destruir)
        {          
            
            Explotar();
            
        }
    }      

    void SumarPuntos()
    {
        for (int i = 0; i < NoPuntos; i++)
        {
            // Marcador miMarcador = new Marcador(); 
            Marcador miMarcador = gameObject.AddComponent<Marcador>();  //Forma correcta de hacerlo
        }
    }

    void Explotar()
    {
        SumarPuntos();
        pc2d.isTrigger = true;
    }
}
