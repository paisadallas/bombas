using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play : MonoBehaviour
{
    public GameObject panelPause;
    public GameObject buttonPause;

    public void BtPlay()
    {
        panelPause.SetActive(false);
        buttonPause.SetActive(true);
        Time.timeScale = 1.0f;
    }
}
