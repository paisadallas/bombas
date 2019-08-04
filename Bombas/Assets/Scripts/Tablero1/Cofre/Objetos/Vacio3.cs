using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Vacio3 : MonoBehaviour
{
    public Sprite relleno;
    public Sprite vacio;
    private SpriteRenderer miImage;


    private void Start()
    {
        miImage = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {

        roca();
    }

    private void roca()
    {
        if (RockX3.roca > 0)
        {
            miImage.sprite = relleno; 
        }
        else
        {
            miImage.sprite = vacio; 
        }
    }
}
