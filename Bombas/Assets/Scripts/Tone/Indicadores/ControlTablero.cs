using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlTablero : MonoBehaviour
{
  
    public int noDisparos;
    
   

    private void Start()
    {
        TotalDisparos.total = noDisparos;       
    }
   
}
