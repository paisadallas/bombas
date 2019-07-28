using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// boton usada por el boton Pause del juego ***///
public class Play : MonoBehaviour
{
    public GameObject panelPause;
    public GameObject buttonPause;

    // Play despues de Pausar Game
    public void BtPlay()
    {
        panelPause.SetActive(false);
        buttonPause.SetActive(true);
        Time.timeScale = 1.0f;
    }  
    
}
