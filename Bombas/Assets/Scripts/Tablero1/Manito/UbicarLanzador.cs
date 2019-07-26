using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//***** objeto ubicado en el Check de mi mano*****///

public class UbicarLanzador : MonoBehaviour
{
    public GameObject manito;
     
    private void Start()
    {          
        
        manito.SetActive(true);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
          
            manito.SetActive(false);
            
        }
                   
            
    }

   

}
