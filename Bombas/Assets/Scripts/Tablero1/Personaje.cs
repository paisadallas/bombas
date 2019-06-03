using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Personaje : MonoBehaviour
{
    public GameObject arma;
    private bool confirmarPos;
    public Contador contadorUno;
    private bool resetContador = true;
    void Start()
    {
        confirmarPos = false;   
    }

    // Update is called once per frame
    void Update()
    {
        //confirmandoPosicion();
                
    }

 
      
    private void confirmandoPosicion()
    {
        if (Input.GetMouseButtonDown(0))
        {
            confirmarPos = true;
            if (resetContador)
            {
                contadorUno.resetContador();
                resetContador = false;
            }

        }
        if (!confirmarPos)
        {
            coordenadasPosicion();
        }

    }
    
    private void coordenadasPosicion()
    {
        float posicionX;
        float posicionY;
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        posicionX = mousePosition.x;
        posicionY = -7.0f;
        if (posicionX <= -4.5f)
        {
            posicionX = -4.5f;
        }
        if(posicionX>= 4.5f)
        {
            posicionX = 4.5f;
        }
        
        arma.transform.position = new Vector2(posicionX, posicionY);
         
    }

    
}
