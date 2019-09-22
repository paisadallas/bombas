using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RockX3Ads : MonoBehaviour
{
    private Transform miPosicion;
    public bool verVideo;
    private float posX;
    int cantidad;
    public AdsRecompenzado publicidad;
    private void Start()
    {
        miPosicion = GetComponent<Transform>();
        verVideo = true;
    }

    private void Update()
    {
        posX = miPosicion.position.x;
        ChecarPosicion();
        Cantidad();
    }

    private void ChecarPosicion()
    {

        if (posX >= 1.5f && verVideo == true)        //evitamos que se reproduzca indefinidamente
        {
            verVideo = false;
            DisparosExtras.extras = 0; //Reiniciamos los disparos Extras  
            if (ActivadorAds.publicidad)
            {
                publicidad.ShowRewardedVideo();  //ACTIVIADOR ADS!!         Descomentarear para Ads
            }
            else
            {
                ReplayLevel();                   // NO ADS !!               Comentarear para Ads
            }

           
        }

    }

    public void ReplayLevel()
    {
        SceneManager.LoadScene("TableroUno");    //Cargo mi escena de nuevo
        NoProyectiles.disparos = 0;   // Reinicio mis diparos
        Puntos.logros = 0;              //Reinicio Puntos
        Marcador.miMarcador = 0;       
        RockX3 unaRoca = new RockX3(cantidad); // agregamos una cantidad de 1 or 2 roca
        LostLevel perdeLevel = new LostLevel();
    }

    public void Cantidad()
    {
        if (LostLevel.no == 6)
        {
            cantidad = 1;
        }

        if (LostLevel.no >= 7)
        {
            cantidad = 2;
            LostLevel.no = 0;
        }
        

    }
}
