using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//**** aplicamos a nuestra burbuja ****///
public class ActivatePoint : MonoBehaviour
{
    public GameObject puntos;
    private CircleCollider2D cc2d;
    void Start()
    {
        cc2d = GetComponent<CircleCollider2D>();
        puntos.SetActive(false); 
    }

    // Update is called once per frame
    void Update()
    {
        if (cc2d.isTrigger)
        {
            puntos.SetActive(true);
        }  
    }
}
