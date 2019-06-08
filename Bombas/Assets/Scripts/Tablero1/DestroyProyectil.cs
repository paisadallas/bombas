using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyProyectil : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D otro)
    {
        if (otro.gameObject.tag == "suelo")
        {
            Destroy(this.gameObject);
            Debug.Log("destruyendo");
        }
       
        
    }
}
