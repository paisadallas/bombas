using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// funcion encargada de cambiar el sprite del boton vacion///
//se aplica al boton Uno

public class Vacio1 : MonoBehaviour
{
    public Sprite relleno;
    public Sprite vacio;
    private SpriteRenderer myImage;

    private void Start()
    {
        myImage = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {

        roca();   
    }

    private void roca()
    {
        if (Rock.roca > 0)
        {
            myImage.sprite = relleno;
            
        }
        else
        {
            myImage.sprite = vacio; 
        }
    }
      
}
