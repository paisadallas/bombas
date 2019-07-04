using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//** Se aplica a nuestros obstaculos ****
public class Obstaculo : MonoBehaviour
{
   // private BoxCollider2D bc2d;
    private Rigidbody2D rb2d;
    private PolygonCollider2D pc2d;
    [Range(1, 5)]
    public int resistencia;
    [Range(0, 10)]
    public int NoPuntos;

    private void Start()
    {
        pc2d = GetComponent<PolygonCollider2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {          
        rb2d = GetComponent<Rigidbody2D>();
        resistencia = resistencia - 1;
        // Debug.Log(resistencia); 
        if (resistencia <= 0)
        {
            SumarPuntos();
            // bc2d.enabled = false;
            pc2d.isTrigger = true;
            rb2d.bodyType = RigidbodyType2D.Dynamic;
            
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
