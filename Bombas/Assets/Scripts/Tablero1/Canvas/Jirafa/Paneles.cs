using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ****** se aplica a nuestra jirafa en escena *****////

public class Paneles : MonoBehaviour
{
    public GameObject panelWinner;
    public GameObject panelLost;
    public GameObject panelTimeEnd;


    // Update is called once per frame
    void Update()
    {
        if (panelWinner.activeSelf || panelLost.activeSelf||panelTimeEnd.activeSelf)
        {
            gameObject.SetActive(false);
        } 
    }
}
