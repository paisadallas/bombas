using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Configuration : MonoBehaviour
{
    public GameObject pausePanel;
    public GameObject winnerPanel;
    public GameObject lostPanel;
    public void panelPause()
    {

        pausePanel.SetActive(true);
        gameObject.SetActive(false);
        Time.timeScale = 0f;
    }

    private void Update()
    {
        if(winnerPanel.activeSelf || lostPanel.activeSelf )
        {
            gameObject.SetActive(false);
        }
        else
        {
            gameObject.SetActive(true);
        }
    }
}
