using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReplayNoAds : MonoBehaviour
{
    private Transform miPosicion;
    private Transform trf;
    public bool verVideo;
    public float posX;
    public GameObject ptoLlegada;     
    Scene scene;
    private void Start()
    {
        miPosicion = GetComponent<Transform>();
        trf = ptoLlegada.GetComponent<Transform>();
        scene = SceneManager.GetActiveScene();
        verVideo = true;
    }

    private void Update()
    {
        posX = miPosicion.position.x;
        ChecarPosicion();
    }

    private void ChecarPosicion()
    {

        if (posX + 0.2f >= trf.position.x && verVideo == true)        //evitamos que se reproduzca indefinidamente
        {
            verVideo = false;
            DisparosExtras.extras = 0; //Reiniciamos los disparos Extras  
          //  playVideo.ShowRewardedVideo();  // play videoRecompensado 
            ReplayLevel();

        }

    }

    public void ReplayLevel()
    {
        SceneManager.LoadScene(scene.name);    //Cargo mi escena de nuevo
        NoProyectiles.disparos = 0;   // Reinicio mis diparos
        Puntos.logros = 0;              //Reinicio Puntos
        Marcador.miMarcador = 0;       // reinicio mi marcador
        LostLevel perdeLevel = new LostLevel();   //Sumamos un leves Lost
    }
}
