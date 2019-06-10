using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TableroUno : MonoBehaviour
{
    [Range(0,10)]
    public int TotalBurbujas;
    public void perder(int disparos)
    {
         if(disparos<= 0)
        {
            Debug.Log("eh perdido");            
            SceneManager.LoadScene("TableroUno");
            NoProyectiles.disparos = 0;   // Reinicio mis diparos
            Puntos.logros = 0;            //Reinicio Puntos
        }
    }  

    private void OnGUI()
    {
        if (GUI.Button(new Rect(10, 10, 50, 30), "Reset"))
        {              
            SceneManager.LoadScene("TableroUno");    //Cargo mi escena de nuevo
            NoProyectiles.disparos = 0;   // Reinicio mis diparos
            Puntos.logros = 0;              //Reinicio Puntos
        }       
            
    }

    public void winnerLevel(int logros)
    {
         if(Puntos.logros== TotalBurbujas)
        {

            Debug.Log("Haz Ganado!!");
        }

    }
}
