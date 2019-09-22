using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apuntador : MonoBehaviour
{
    
    
    public GameObject centroObjet;    
    public GameObject[] puntos;
    public GameObject apuntador;
    private bool press;
    public bool cargado;
    [Range(-10,0)]
    public float posY;
    public float desvidacion;

    public float posx;
    private void Start()
    {
        cargado = true;
        press = true;
        press = false;
    }   

    private void Update()
    {          

        if (press && cargado == true)
        {
           
            apuntando();
        }
    }           

    private void apuntando()
    {
        float x1, x2, xr,y1,y2,yr;
        float posX;
                
        if (press)
        {                
            float tiempo = Time.deltaTime;
            //Vector X  Magnitud
            x1 = gameObject.transform.position.x;
            x2 = centroObjet.transform.position.x;
            xr = x1 - x2;   // valor de X
            posX = x2 - xr;
            //Valor de Y Magnitud
            y1 = gameObject.transform.position.y;
            y2 = centroObjet.transform.position.y;
            yr = y2 - y1;
            posY = y2 + yr;
          
            puntos[0].transform.position = new Vector3(posX, posY, 0);
            puntos[1].transform.position = new Vector3(posX - xr, posY + yr, 0);
            puntos[2].transform.position = new Vector3(posX - 2*xr, posY + yr + yr, 0);            //2
            puntos[3].transform.position = new Vector3(posX -desvidacion*xr, posY + yr + yr + yr, 0);    //3.3f
          
        }           
       
    }
     
    private void OnMouseDown()
    {

        press = true;
        apuntador.SetActive(true); //activamos apuntador
        puntos[0].SetActive(true);
        puntos[1].SetActive(true);
        puntos[2].SetActive(true);
        puntos[3].SetActive(true);

    }
    // proyectil lanzado objeto lanzado
    private void OnMouseUp()
    {
        puntos[0].SetActive(false);
        puntos[1].SetActive(false);
        puntos[2].SetActive(false);
        puntos[3].SetActive(false);
      
    }
}
