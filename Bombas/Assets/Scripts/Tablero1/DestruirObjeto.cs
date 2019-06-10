using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//**** Se aplica a nuestros Objestos (Obstaculos, ItemInteriores)

public class DestruirObjeto : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D otro)
    {
       
        if (otro.gameObject.tag == "suelo")
        {
            // Debug.Log("Destruido");
            Destroy(gameObject);
        }   
    }
}
