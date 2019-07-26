using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//***** Se aplica en mi ItemInterior *******

public class Cofre : MonoBehaviour
{   
    [Range(0,20)]
    public int NoPuntos;    
    private void Start()
    {
        NoPuntos = 10;               
    }

    void OnTriggerEnter2D(Collider2D otro)
    {                         
        if (otro.gameObject.tag == "Logro")
        {                 
            for (int i = 0; i < NoPuntos; i++)
            {
                // Marcador miMarcador = new Marcador(); 
               Marcador miMarcador = gameObject.AddComponent<Marcador>();  //Forma correcta de hacerlo
            } 
            Puntos winnerPuntos = new Puntos();    //Puntos para ganar Level
            Destroy(gameObject);    //Destruimos nuestro Item Interior
        }                 
    }
}
         
   