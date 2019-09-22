using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Publicidad : MonoBehaviour
{
    public bool publicidad;

    private void Start()
    {
        //publicidad = true;
        //publicidad=false;
    }
    // Update is called once per frame
    void Update()
    {
        ActivadorAds.publicidad = publicidad; 
    }
}
