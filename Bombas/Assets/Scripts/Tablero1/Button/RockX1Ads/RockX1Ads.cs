using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RockX1Ads : MonoBehaviour
{
    private Transform miPosicion;
    public bool verVideo;
    private float posX;
    private int cantidad;
    public AdsRecompenzado publicidad;
    private void Start()
    {
        miPosicion = GetComponent<Transform>();
        verVideo = true;
        
    }

    private void Update()
    {
        posX = miPosicion.position.x;
        Cantidad();
        ChecarPosicion();
    }

    private void ChecarPosicion()
    {

        if (posX >= 1.5f && verVideo == true)        //evitamos que se reproduzca indefinidamente
        {
            verVideo = false;
            DisparosExtras.extras = 0; //Reiniciamos los disparos Extras 
            if (ActivadorAds.publicidad)
            {
                 publicidad.ShowRewardedVideo();     //ACTIVADOR ADS!!!    Descomentarear para Ads
            }
            else
            {
                ReplayLevel();                      //NO ADS!!              Comentarear Ads
            }


           
        }

    }

    public void ReplayLevel()
    {        
            SceneManager.LoadScene("TableroUno");    //Cargo mi escena de nuevo
            NoProyectiles.disparos = 0;   // Reinicio mis diparos
            Puntos.logros = 0;              //Reinicio Puntos
            Marcador.miMarcador = 0;        
            RockX1 unaRoca = new RockX1(cantidad); // agregamos una cantidad de 1 or dos de roca
            LostLevel perdeLevel = new LostLevel();   //Subimos nivel de recompenza
    }

    //segun las veces perdidas Sumamos cierta cantidad

    public void Cantidad()
    {
        if (LostLevel.no == 4)
        {
            cantidad = 1;
        }

        if (LostLevel.no == 5)
        {
            cantidad = 2;
        }

    }
}
