using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//****** Aplicamos a nuetra Camara**************

public class TableroUno : MonoBehaviour
{
    [Range(0,10)]
    public int TotalBurbujas;
    public GameObject winnerCanvas;
    public GameObject lostCanvas;
    public GameObject panelTimeEnd;
    private AudioSource audioTablero;
    
    private void Start()
    {
        audioTablero = GetComponent<AudioSource>();
       
    }
    private void Update()
    {
        winnerLevel(TotalBurbujas);
        if (panelTimeEnd.activeSelf)
        {
            audioTablero.Stop();
        }
        int disparos = TotalDisparos.total - (NoProyectiles.disparos) + DisparosExtras.extras;
        perder(disparos);
    } 
           
    public void perder(int disparos)
    {
         if(disparos<= 0 && !winnerCanvas.activeSelf)    //evitamos ganar y perder a la vez
        {                  
                lostCanvas.SetActive(true);
            Mute();            
        }
    } 
          
     
    public void winnerLevel(int logros)
    {
         if(Puntos.logros== TotalBurbujas && !lostCanvas.activeSelf)
        {

            // Debug.Log("Haz Ganado!!");
            //  winnerCanvas.SetActive(true);             
            winnerCanvas.SetActive(true);
            audioTablero.Stop();
        }

    }    
    public void PerderNivel()
    {
        Debug.Log("Haz perdido Nivel");    
    }

   public void Mute()
    {
        audioTablero.volume=0.0f;
    }

    public void NoMute()
    {
        audioTablero.volume = 0.3f;
    }
}
