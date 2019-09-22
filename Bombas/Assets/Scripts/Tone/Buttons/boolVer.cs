using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class boolVer : MonoBehaviour
{
    private Button estate;

    private void Start()
    {
        estate = GetComponent<Button>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Ver.ver <= 0)
        {
            estate.interactable = false;
        }
        else
        {
            estate.interactable = true;
        }

    }
}
