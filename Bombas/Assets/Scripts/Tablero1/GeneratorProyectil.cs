using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// **** DISPARADOR ***
public class GeneratorProyectil : MonoBehaviour
{

    public float waitTime = 1;
    private SpringJoint2D sj2d;
    //float x, y;
    WaitForSecondsRealtime waitForSecondsRealtime;
    //public GameObject armaBasica;

    IEnumerator DoWait()
    {
        //   Debug.Log("Generando... ");

        if (waitForSecondsRealtime == null)
            waitForSecondsRealtime = new WaitForSecondsRealtime(waitTime);
        else
            waitForSecondsRealtime.waitTime = waitTime;
        yield return waitForSecondsRealtime;
        Instantiate(this.gameObject, new Vector3(0, -7, 73), Quaternion.identity);
        // Debug.Log("exito!!");
    }

    public void crearProyectil(bool nuevo)
    {
        //nuevo = checarestado.cargado;
        if (nuevo)
        {
            Debug.Log("entrando!!!!");
            StartCoroutine(DoWait());
        }
    }


    //void OnTriggerEnter2D(Collider2D otro)
    //{
    //    if (sj2d.enabled = false)
    //    {
    //        //Instantiate(this.gameObject, new Vector3(0,-7,73), Quaternion.identity); 
    //        crearProyectil(true);
    //    }

    //}
}
