using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClaseHija : MonoBehaviour
{
   public ClasePadre estadoPadre;

    public bool estado;

    private void Update()
    {
        estado = estadoPadre.estado;
    }

}
