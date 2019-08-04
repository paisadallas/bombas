using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioCheck : MonoBehaviour
{

    // Ubicamos en objeto roca//

        //Mejorar la sensacion Touch
    private CircleCollider2D cc2d;

    private void Start()
    {
        cc2d = GetComponent<CircleCollider2D>();
        cc2d.radius = 1.5f;
    }

    private void OnMouseDown()
    {
        cc2d.radius = 0.33f;
    }
}
