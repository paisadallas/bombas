using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
