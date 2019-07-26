using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//****aplicamos a nuestra roca y agregamos nuestro panel Pause*****

public class PauseProyectil : MonoBehaviour
{
    public GameObject panelPause;
    public GameObject panelWinner;
    public GameObject panelLost;
    private CircleCollider2D cc2d;
    // Update is called once per frame
    private void Start()
    {
        cc2d = GetComponent<CircleCollider2D>();
    }

    void Update()
    {
        if (panelPause.activeSelf == true || panelWinner.activeSelf== true || panelLost.activeSelf)
        {
            cc2d.enabled = false;
        }
        else {
            cc2d.enabled = true;
        }
          
        
    }
}
