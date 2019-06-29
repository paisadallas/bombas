using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  //agrego esta libreria


//**** se aplica a mi canvas puntos ****
public class ContadorPuntos : MonoBehaviour
{
    
    public Text totalMarcador;     
    private float marcador;   
    private float tiempo = 0f;
    private int velocidad;
    void Start()
    {         
        marcador = Marcador.miMarcador;
        totalMarcador.text = "" + tiempo;        
        velocidad = 20;
    }

    // Update is called once per frame
    void Update()
    {       
        Conteo(marcador);
        Debug.Log(Marcador.miMarcador);
    }

    private void Conteo(float marcador)
    {
        if (tiempo < Marcador.miMarcador)
        {
            tiempo += Time.deltaTime*velocidad;
            // marcador = tiempo.ToString("f0");         
        }
      
        totalMarcador.text = " " + tiempo.ToString("f0");  
    }   
   
}
