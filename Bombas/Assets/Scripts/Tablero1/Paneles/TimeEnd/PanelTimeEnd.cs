using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelTimeEnd : MonoBehaviour
{

    // Clase no se asigna a ningun Objeto!!!
    
    public GameObject manito;
    public GameObject manito2;
    public GameObject canvasPosicion;       

    // Update is called once per frame
    void Start()
    {
        manito2.SetActive(false);
        manito.SetActive(false);
        canvasPosicion.SetActive(false);       
    }

}
