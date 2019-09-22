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
    [Range(0,50)]
    public int puntosUno;
    [Range(0, 50)]
    public int puntosDos;
    [Range(0, 50)]
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
            StartCoroutine(Release(2));


        }
        if (Marcador.miMarcador >= puntosTres)
        {

            StartCoroutine(Release(3));
        }

    }

    private IEnumerator Release(int start)
    {
        if (start == 2)
        {
            yield return new WaitForSeconds(0.5f);
            star2.SetActive(true);
        }
        if (start == 3)
        {
            yield return new WaitForSeconds(1.0f);
            star3.SetActive(true);
        }


    }
}
