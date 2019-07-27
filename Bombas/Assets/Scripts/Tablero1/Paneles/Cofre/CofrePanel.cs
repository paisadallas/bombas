using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CofrePanel : MonoBehaviour
{

    //****** ubicado en mi panel Cofre*****////

    public GameObject panelTimeEnd;
    public GameObject panelWinner;
    public GameObject panelLost;
    
    // Update is called once per frame
    void Update()
    {
        // Desactivamos con cualquiera de estos paneles
        if (panelTimeEnd.activeSelf || panelLost.activeSelf || panelWinner.activeSelf)
        {
            
            this.gameObject.SetActive(false);    //Desactivamos nuestro cofre si Timer = 0
            
        }      

    }
}
