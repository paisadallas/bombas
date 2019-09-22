using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class boolBoomX2 : MonoBehaviour
{
    private Button estate;

    private void Start()
    {
        estate = GetComponent<Button>();
    }
    // Update is called once per frame
    void Update()
    {
        if (BoomX2.boomX2 <= 0)
        {
            estate.interactable = false;
        }
        else
        {
            estate.interactable = true;
        }

    }
}
