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
    public PoderActual spriteActual; //Clase padre de poderes

    public int idRoca;
    
    public void RocaXNormal()       //roca Normal
    {           
        if (Rock.roca > 0)     //si tenemos rocas
        {
            Debug.Log("AGG ROCK!");
            contadorProyectiles.extras++;      //agregamos una roca!! 
            Rock rocaUsada = new Rock(-1); //quitamos Una Roca !!
            panelCofre.SetActive(false);
            spriteActual.poderActual = 0;
        }
        else
        {
            Debug.Log("Sin rocas");
        }
       
    }

    public void RocaXPoder1()
    {
        if(RockX1.roca > 0)
        {
            contadorProyectiles.extras++;      //agregamos una roca a la partida
            RockX1 rocaUsada = new RockX1(-1);  //quitamos Una Roca Poder
            activadorPoder.estado = true;
            panelCofre.SetActive(false);
            spriteActual.poderActual = 1;
        }       
         else{
            Debug.Log("Sin rocas");
        }
    }
   

    
}
