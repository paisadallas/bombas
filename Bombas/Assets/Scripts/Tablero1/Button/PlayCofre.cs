using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayCofre : MonoBehaviour
{
    //******* ubicado en mi boton play de panel cofre ******
    public GameObject panelCofre;
  
    // Quitar Panel Cofre
    public void CloseCofre()
    {
        
        panelCofre.SetActive(false);
       
    }
}
