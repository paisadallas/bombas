using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ****** se aplica a nuestra jirafa en escena *****////

public class Paneles : MonoBehaviour
{
    public GameObject panelWinner;

    
    // Update is called once per frame
    void Update()
    {
        if (panelWinner.activeSelf)
        {
            gameObject.SetActive(false);
        } 
    }
}
