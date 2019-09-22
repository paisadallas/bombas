using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnaUnaPanel : MonoBehaviour
{
    public GameObject panelLost;
      

    // Update is called once per frame
    void Update()
    {
        if (panelLost.activeSelf)
        {
            this.gameObject.SetActive(false);
        } 
    }
}
