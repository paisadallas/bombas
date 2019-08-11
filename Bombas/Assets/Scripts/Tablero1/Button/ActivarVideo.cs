using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//***** aplicamos a la igamen que vamos a mover (estamos arrastrando)******
public class ActivarVideo : MonoBehaviour
{
    public AdsRecompenzado playVideo;
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

        if (posX >= 1.5f && verVideo == true)
        {
            verVideo = false;
            DisparosExtras.extras = 0; //Reiniciamos los disparos Extras
            playVideo.ShowRewardedVideo();    //ATIVADOR ADS!!!!
        }

    }


}
    

