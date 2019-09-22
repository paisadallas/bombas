using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golpes : MonoBehaviour
{
    // private BoxCollider2D bc2d;
    private Rigidbody2D rb2d;
    private PolygonCollider2D pc2d;
    [Range(0, 5)]
    public int resistencia;
    [Range(0, 10)]
    public int NoPuntos;
    public bool destruir;
    private Animator animator;

   // public ClasePadre clasePadre;

    private void Start()
    {
        pc2d = GetComponent<PolygonCollider2D>();
        destruir = false;   // poder de destruir al primer contacto! 
        animator = GetComponent<Animator>();
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
      //  destruir = clasePadre.estado;
        rb2d = GetComponent<Rigidbody2D>();
        resistencia = resistencia - 1;

        if (resistencia <= 0)
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
     //FUNCION USADA POR EL BOTON
    public void verObstaculo()
    {
        animator.Play("Inicio");
    }
}
