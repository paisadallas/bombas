using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//***** Aplicamos a nuestro inten interior de la burbuja *****

public class Premios : MonoBehaviour
{
    public TableroUno totalPuntos;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Burbuja")
        {
            Puntos puntos = new Puntos();
            Debug.Log("Puntos=" + Puntos.logros);
            totalPuntos.winnerLevel(Puntos.logros); //Estado del nivel
        }
    }       
}
