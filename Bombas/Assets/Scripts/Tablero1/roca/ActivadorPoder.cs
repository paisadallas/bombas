using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivadorPoder : MonoBehaviour
{
    public ClasePadre clasePadre;

    [Range(0,10)]
   public int totalObstaculos;
    
    private void Start()
    {
        totalObstaculos = 1;
         
    }

    void OnTriggerEnter2D(Collider2D otro)
    {
        if (otro.gameObject.tag == "suelo")
        {
            clasePadre.estado = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Obstaculo")
        {               
            if (totalObstaculos <= 0)
            {
                clasePadre.estado = false;
            }
            totalObstaculos = totalObstaculos-1;             
        }
    }

}
