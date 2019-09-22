using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//***encargado de saber cuantas veces pierde por nivel  ****
//asi gestionamos la publicidad

public class LostLevel 
{
   public static int  no = 0;

    public LostLevel()
    {
        no++;  
    }
}
