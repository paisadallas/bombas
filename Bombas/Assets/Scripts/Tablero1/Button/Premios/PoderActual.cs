using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//********   Contenderor de botones para activar poderes *****///

public class PoderActual : MonoBehaviour
{
    public int poderActual;
    public int explociones;

    private void Start()
    {
        poderActual = 0; // seleccionar el Sprite
        explociones = 0; // objetos explotados al primer toque
    }

}
