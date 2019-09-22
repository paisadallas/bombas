using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipoPremio : MonoBehaviour
{
    public bool boom, boomX2, rock, ver;
    public int cantidad;
    public bool activado;
    // Update is called once per frame
    void Update()
    {
        if (LostLevel.no % 2 == 0)
        {

            cantidad = 2;
        }
        else
        {

            cantidad = 1;
        }

      //  activado = this.gameObject.active;
        activado = this.gameObject.activeSelf;
    }
    
}

