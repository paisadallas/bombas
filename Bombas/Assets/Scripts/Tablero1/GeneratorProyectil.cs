using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// **** DISPARADOR ***
public class GeneratorProyectil : MonoBehaviour
{

    //public float waitTime = 3;
    //float x, y;
    //WaitForSecondsRealtime waitForSecondsRealtime;
    //public GameObject armaBasica;
    public Proyectil checarestado;
    //IEnumerator DoWait()
    //{
    // //   Debug.Log("Generando... ");

    //    if (waitForSecondsRealtime == null)
    //        waitForSecondsRealtime = new WaitForSecondsRealtime(waitTime);
    //    else
    //        waitForSecondsRealtime.waitTime = waitTime;
    //    yield return waitForSecondsRealtime;
    //    Instantiate(armaBasica, new Vector3(0,-7,73), Quaternion.identity);
    //   // Debug.Log("exito!!");
    //}

    // public void crearProyectil(bool nuevo)
    //{
    //    nuevo = checarestado.cargado;
    //    if (nuevo)
    //    {
    //        Debug.Log("entrando!!!!");
    //        StartCoroutine(DoWait());
    //    }
    //}


    void OnTriggerEnter2D(Collider2D otro)
    {
        if (otro.tag == "Proyectiles")
        {
             Debug.Log("ESTADO?");                  
        }


    }
}
