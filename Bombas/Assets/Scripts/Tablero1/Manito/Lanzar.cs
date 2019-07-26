using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//**** Debe ir el objeto Arrastrar ****
public class Lanzar : MonoBehaviour
{
  
    public GameObject manito;

    private void Start()
    {
       // manito.SetActive(true);
    }

    private void OnMouseDown()
    {
        manito.SetActive(false);
        
    }
}
