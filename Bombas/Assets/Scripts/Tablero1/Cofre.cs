using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//***** va en mi ItemInterior *******

public class Cofre : MonoBehaviour
{
    int NoPuntos;    
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
                Marcador miMarcador = new Marcador();

            } 
        }
    }

    
}
