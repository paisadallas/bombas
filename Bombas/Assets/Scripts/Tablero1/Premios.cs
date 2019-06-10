using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
