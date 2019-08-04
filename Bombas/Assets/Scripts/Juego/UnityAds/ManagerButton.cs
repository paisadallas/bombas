using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerButton : MonoBehaviour
{
    //ACTIVAMOS O DESACTIVAMOS NUESTRO BUTTON SEGUN LAS VECES QUE  PIERDEN

    public GameObject buttonReplay;
    public GameObject buttonRock;
    public GameObject buttonRockx1;
    public GameObject buttonRockX3;

    private void Start()
    {
        buttonReplay.SetActive(false);
        buttonRock.SetActive(false);
        buttonRockx1.SetActive(false);
        buttonRockX3.SetActive(false);
    }

    private void Update()
    {
        Ventanas();
    }

    public void Ventanas()
    {
        if (LostLevel.no == 0 || LostLevel.no == 1)
        {
            buttonReplay.SetActive(true);
        }
        if (LostLevel.no == 2 || LostLevel.no == 3)
        {
            buttonRock.SetActive(true);
        }
        if (LostLevel.no == 4 || LostLevel.no == 5)
        {
            buttonRockx1.SetActive(true); 
        }
        if ( LostLevel.no >= 6)
        {
            buttonRockX3.SetActive(true);
        }
    }
}
