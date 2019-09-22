using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOffSound : MonoBehaviour
{
    private float contador;
    public TableroUno tableroUno;
    public void Mute()
    {
        contador++;         
        if (contador % 2 == 0)
        {
            tableroUno.NoMute();

        }
        else
        {
            
            tableroUno.Mute();
        }

    }
}
