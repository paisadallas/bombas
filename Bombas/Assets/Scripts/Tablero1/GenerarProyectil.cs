using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerarProyectil : MonoBehaviour
{
    [Range(1, 10)]
    public int disparos;
    int misDisparos = 0;
    public Proyectil posX;
    void OnTriggerEnter2D(Collider2D otro)
    {
        //Generamos Nuevo proyectil
        if (otro.gameObject.tag == "Proyectiles" && (disparos-1) > NoProyectiles.disparos)
        {               
            Instantiate(gameObject, new Vector3(posX.posX, -7, 0), Quaternion.identity);              
        }
        // Destruimos los disparos
        if (otro.gameObject.tag == "suelo")
        {
            NoProyectiles proyectiles = new NoProyectiles();
            // Debug.Log("Destruido");
            DisparosDispoblibles(disparos);
            Destroy(gameObject);
        }
    }

    void DisparosDispoblibles(int misDisparos)
    {
        misDisparos = misDisparos - NoProyectiles.disparos;
        Debug.Log("disponibles =" + misDisparos);

    }
}
