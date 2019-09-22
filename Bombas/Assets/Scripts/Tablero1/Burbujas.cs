using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//**** Aplicamos a nuestras burbujas **********

public class Burbujas : MonoBehaviour
{     
    private CircleCollider2D cc2d;
    private CircleCollider2D cc2dItem;
    private Rigidbody2D rb2dItem;
    private Animator animator;
    public GameObject ItemInterior;
    [Range(0,100)]
    public int NoPuntos = 10;    // por burbuja
    [Range(1, 5)]
    public int resistencia;

    private void Start()
    {
        cc2d = GetComponent<CircleCollider2D>();
        rb2dItem = ItemInterior.GetComponent<Rigidbody2D>();
        cc2dItem = ItemInterior.GetComponent<CircleCollider2D>();
        animator = gameObject.GetComponent<Animator>();
        cc2d.isTrigger = false;
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {          
        resistencia = resistencia - 1;
        animator.SetInteger("resistencia", resistencia);
       // Debug.Log(resistencia); 
        if (resistencia <= 0)
        {
            cc2d.enabled = false;
            cc2d.isTrigger = true;           
            cc2dItem.isTrigger = true;                       
            rb2dItem.drag = 1;
            Puntos logrado = new Puntos();
            SumarPuntos();
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
}
