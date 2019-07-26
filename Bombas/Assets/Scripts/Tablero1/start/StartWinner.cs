using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//***** se aplica al objeto que contiene la estrellas *******
public class StartWinner : MonoBehaviour
{
    public Sprite startOn;
    public Sprite startOff;
    public GameObject star1;
    public GameObject star2;
    public GameObject star3;

    private AudioSource miAudio;
    [Range(1,20)]
    public int puntosUno;
    [Range(20, 30)]
    public int puntosDos;
    [Range(30, 40)]
    public int puntosTres;
      
    void Update()
    {
        totalStart();
        
    }

    void totalStart()
    {
        if(Marcador.miMarcador >= puntosUno)
        {
           
            star1.SetActive(true);
        }
        if (Marcador.miMarcador >= puntosDos)
        {
            
            star2.SetActive(true);
           
        }
        if (Marcador.miMarcador >= puntosTres)
        {
           
            star3.SetActive(true);
        }

    }
}
