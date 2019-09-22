using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radio : MonoBehaviour
{
    private CircleCollider2D cc2d;
    // Start is called before the first frame update
    void Start()
    {
        cc2d = GetComponent<CircleCollider2D>();
        
    }

    private void OnMouseDown()
    {
        cc2d.radius = 50;
    }
}
