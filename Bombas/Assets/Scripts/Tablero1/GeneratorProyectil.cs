using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// **** DISPARADOR ***
public class GeneratorProyectil : MonoBehaviour
{

   public float waitTime = 3;
    float x, y;
    WaitForSecondsRealtime waitForSecondsRealtime;
    public GameObject armaBasica;
    IEnumerator DoWait(float x)
    {
     //   Debug.Log("Generando... ");

        if (waitForSecondsRealtime == null)
            waitForSecondsRealtime = new WaitForSecondsRealtime(waitTime);
        else
            waitForSecondsRealtime.waitTime = waitTime;
        yield return waitForSecondsRealtime;
        Instantiate(armaBasica, new Vector3(x,-7,73), Quaternion.identity);
       // Debug.Log("exito!!");
    }

     public void crearProyectil(bool nuevo,float x)
    {
        if (nuevo)
        {
            StartCoroutine(DoWait(x));
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("exito");
    }
}
