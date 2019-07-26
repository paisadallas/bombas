using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recompenza : MonoBehaviour
{
    public GameObject masUno;
    void Start()
    {
       if(DisparosExtras.extras >= 1)
        {
            masUno.SetActive(true);
        }
    }
         
}
