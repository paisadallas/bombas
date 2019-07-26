using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// ****  Aplicamos a nuestra plataforma ***
public class ActivePointOb : MonoBehaviour
{
    public GameObject puntos;
    private PolygonCollider2D pc2d;
    void Start()
    {
        pc2d = GetComponent<PolygonCollider2D>();
        puntos.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (pc2d.isTrigger)
        {
            puntos.SetActive(true);
        }
    }
}
