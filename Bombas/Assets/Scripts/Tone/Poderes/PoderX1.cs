using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//****** Aplicamos a nuestro contenedor de poderes********

public class PoderX1 : MonoBehaviour
{
    public  Golpes []ob;
#pragma warning disable 0649 // variable declared but not used.
    private Collision2D c2d;
    int qty;

    void Start()
    {
        
    }

    void Update()
    {
        qty = ob.Length; 
    }

    //PODER X1
    public void PoderUno()
    {
       for(int i =0; i< qty; i++)
        {
            if (ob[i].resistencia > 0)
            {
                ob[i].OnCollisionEnter2D(c2d);
               
            }
        } 
    }
    //PODER X2
    public void poderDos()
    {
        for (int i = 0; i < qty; i++)
        {
            if (ob[i].resistencia > 0)
            {
                for (int j = 0; j< 2; j++)
                {
                    ob[i].OnCollisionEnter2D(c2d);
                }
                    
            }
        }

    }
    // PODER VER OBSTACULOS
    public void poderVer()
    {
        for (int i = 0; i < qty; i++)
        {
            if (ob[i].resistencia > 0)
            {                      
                    ob[i].verObstaculo();          
            }
        }
    }
}
