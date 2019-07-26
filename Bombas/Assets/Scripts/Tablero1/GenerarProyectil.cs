using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//***** Se aplica a nuestro proyectil (roca)***

public class GenerarProyectil : MonoBehaviour
{
   
    public int disparos;     
    public TableroUno checar;
    public GameObject disparador;
    private Transform coordenadasX;

    public ContadorProyectiles noProyectiles;     
    public int extras;
    
    private void Start()
    {
       // disparos = noProyectiles.disponibles;
        coordenadasX = disparador.GetComponent<Transform>();
    }

    public void Update()
    {
        disparos = noProyectiles.bolas;
        extras = noProyectiles.extras;
    }
    void OnTriggerEnter2D(Collider2D otro)
    {
        //Generamos Nuevo proyectil
        if (otro.gameObject.tag == "Proyectiles" && (extras + disparos-1) > NoProyectiles.disparos)
        {               
           Instantiate(gameObject, new Vector3(disparador.transform.position.x+0.35f, -7, 0), Quaternion.identity);  //0.35 Delay posicion            
        }
        // Destruimos los disparos
        if (otro.gameObject.tag == "suelo")   //Tocamos el Tag Suelo
        {
            NoProyectiles proyectiles = new NoProyectiles(); //Creamos contador de proyectil            
            DisparosDispoblibles(disparos+extras);
            Destroy(gameObject);
        }
    }

    //Llamamos panel Lost
    void DisparosDispoblibles(int misDisparos)
    {
        misDisparos = misDisparos - NoProyectiles.disparos;         
        checar.perder(misDisparos);  // no tenemos disparos
    }
         
}
