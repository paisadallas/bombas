using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Levitacion : MonoBehaviour
{
    private Transform trf;     
    private float moveSpeed;
    [Range(0, 1)]
    public float disX;
    [Range(0,1)]
    public float disY;
    private float disMaxX, disMaxY;
    private float posActualX, posActualY;
    [Range(0, 1)]
    public float velocidadX;
    [Range(0,1)]
    public float velocidadY;
    private bool x, y;

    void Start()
    {
        moveSpeed = 1;
        trf = GetComponent<Transform>();
        posActualX = trf.position.x;
        posActualY = trf.position.y;
        x = true;
        y = true;
    }

    void Update()
    {         
        DisMax();
        MovementY();
        MovementX();
        transform.Translate(new Vector2(velocidadX,velocidadY) * moveSpeed * Time.deltaTime);    
    }  
  
    private void MovementX() {
      
       if(trf.position.x > disMaxX && x)
        {                
            velocidadX = velocidadX * (-1);
            x = false;
        }

       if(trf.position.x < posActualX && !x)     //X evita ciclo infinito
        {                        
           velocidadX = velocidadX * (-1);
            x = true;
        }
       
    }

    private void MovementY()
    {
       
        if (trf.position.y >= disMaxY && y)    //Y garantiza no entrar ciclo infinito
        {
            velocidadY = (-1) * velocidadY;
            y = false;
        }

        if (trf.position.y < posActualY && !y)
        {                 
                velocidadY = (-1) * velocidadY;
            y = true;
        }
    }

    private void DisMax()
    {
        disMaxX = posActualX + disX;
        disMaxY = posActualY + disY;         
    }
}
