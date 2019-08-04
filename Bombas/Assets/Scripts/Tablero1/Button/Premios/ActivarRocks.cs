using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarRocks : MonoBehaviour
{
    // Funcion encargada de agregar, quitar y validar rocas ///
    // Usamos en nuestro botones del cofre /////

    public GameObject panelCofre;    
    public ContadorProyectiles contadorProyectiles;
    public ClasePadre activadorPoder;
    public PoderActual objetos; //Clase padre, Contenedor de mis botones de poderes

    private int idRoca;
    
    public void RocaXNormal()       //roca Normal
    {           
        if (Rock.roca > 0)     //si tenemos rocas
        {
            Debug.Log("AGG ROCK!");
            contadorProyectiles.extras++;      //agregamos una roca!! 
            Rock rocaUsada = new Rock(-1); //quitamos Una Roca !! 
            panelCofre.SetActive(false);
            objetos.poderActual = 0;
        }
        else
        {
            Debug.Log("Sin rocas");
        }
       
    }

    //Explota solo un objetos
    public void RocaXPoder1()
    {
        if(RockX1.roca > 0)
        {
            contadorProyectiles.extras++;      //agregamos una roca a la partida
            RockX1 rocaUsada = new RockX1(-1);  //quitamos Una RocaX1 Poder
            activadorPoder.estado = true;       //Destruimos a un toque!
            panelCofre.SetActive(false);
            objetos.poderActual = 1;
            objetos.explociones = 1;           //Solo una explocion
        }       
         else{
            Debug.Log("Sin rocas");
        }
    }

    //Explotamos tres objetos
    public void RocaXPoder2()                  
    {
        if (RockX3.roca > 0)
        {
            contadorProyectiles.extras++;      //agregamos una roca a la partida
            RockX3 rocaUsada2 = new RockX3(-1);  //quitamos Una RocaX1 Poder 
            activadorPoder.estado = true;       //Destruimos a un toque!
            panelCofre.SetActive(false);
            objetos.poderActual = 2;
            objetos.explociones = 3;   //Tres explociones 
        }
        else
        {
            Debug.Log("Sin rocas");
        }
    }

}
