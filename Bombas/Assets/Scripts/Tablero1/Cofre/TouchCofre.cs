using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

// lo agregamos a nuestro cofre 

public class TouchCofre : MonoBehaviour
{

    public GameObject panelCofre;   

  public void cofre()
    {           
        if (!panelCofre.activeSelf)
        {              
            panelCofre.SetActive(true);   //siempre  y cuando no exista
         
        }
    }
}
