using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  //agrego esta libreria
using TMPro;


//**** se aplica a mi canvas puntos ****
public class ContadorPuntos : MonoBehaviour
{
    
      
    public TextMeshProUGUI tMarcador;
    private float marcador;   
    private float tiempo = 0f;
    private int velocidad;
    void Start()
    {         
        marcador = Marcador.miMarcador;
        
        tMarcador.text = "" + tiempo;
        velocidad = 20;
    }

    // Update is called once per frame
    void Update()
    {       
        Conteo(marcador);          
    }

    private void Conteo(float marcador)
    {
        if (tiempo < Marcador.miMarcador)
        {
            tiempo += Time.deltaTime*velocidad;
          //   marcador = tiempo.ToString("f0");         
        }
      
       
        tMarcador.text = " " + tiempo.ToString("f0");
    }   
   
}
