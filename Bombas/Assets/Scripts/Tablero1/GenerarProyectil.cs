using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//***** Se aplica a nuestro proyectil (roca)***

public class GenerarProyectil : MonoBehaviour
{
    [Range(1, 10)]
    public int disparos;     
    public Proyectil posX;
    public TableroUno checar;
    public GameObject disparador;
    private Transform coordenadasX;
    
    private void Start()
    {
        coordenadasX = disparador.GetComponent<Transform>();
    }
    void OnTriggerEnter2D(Collider2D otro)
    {
        //Generamos Nuevo proyectil
        if (otro.gameObject.tag == "Proyectiles" && (disparos-1) > NoProyectiles.disparos)
        {               
            Instantiate(gameObject, new Vector3(disparador.transform.position.x+0.35f, -7, 0), Quaternion.identity);  //0.35 Delay posicion            
        }
        // Destruimos los disparos
        if (otro.gameObject.tag == "suelo")
        {
            NoProyectiles proyectiles = new NoProyectiles(); //Creamos nuevo proyectil
            // Debug.Log("Destruido");
            DisparosDispoblibles(disparos);
            Destroy(gameObject);
        }
    }

    void DisparosDispoblibles(int misDisparos)
    {
        misDisparos = misDisparos - NoProyectiles.disparos;
       // Debug.Log("disponibles =" + misDisparos);
        checar.perder(misDisparos);
    }
      
}
