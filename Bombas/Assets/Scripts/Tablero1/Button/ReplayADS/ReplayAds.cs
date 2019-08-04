using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReplayAds : MonoBehaviour
{
    private Transform miPosicion;
    public bool verVideo;
    private float posX;
    private void Start()
    {
        miPosicion = GetComponent<Transform>();
        verVideo = true;
    }

    private void Update()
    {
        posX = miPosicion.position.x;
        ChecarPosicion();
    }

    private void ChecarPosicion()
    {

        if (posX >= 1.5f && verVideo == true)        //evitamos que se reproduzca indefinidamente
        {
            verVideo = false;
            DisparosExtras.extras = 0; //Reiniciamos los disparos Extras
                                       // playVideo.ShowRewardedVideo();  // play videoRecompensado
            ReplayLevel();
        }

    }

    private void ReplayLevel()
    {
        SceneManager.LoadScene("TableroUno");    //Cargo mi escena de nuevo
        NoProyectiles.disparos = 0;   // Reinicio mis diparos
        Puntos.logros = 0;              //Reinicio Puntos
        Marcador.miMarcador = 0;
        LostLevel perdeLevel = new LostLevel();   //NO sumamos nada
    }
}
