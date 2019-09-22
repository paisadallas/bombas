using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class boolBoom : MonoBehaviour
{
    private Button estate;

    private void Start()
    {
        estate = GetComponent<Button>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Boom.boom <= 0)
        {
            estate.interactable = false;
        }
        else {
            estate.interactable = true;
        }
        
    }
}
