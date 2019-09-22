using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class NoDisparos : MonoBehaviour
{
    public TextMeshProUGUI tMarcador;
    float disparos;
    float disponibles;
    

    // Update is called once per frame
    void Update()
    {
        disponibles = TotalDisparos.total- NoProyectiles.disparos+ DisparosExtras.extras;   //agg extras
        tMarcador.text = "x" + disponibles.ToString("f0"); 
      
    }  
}
