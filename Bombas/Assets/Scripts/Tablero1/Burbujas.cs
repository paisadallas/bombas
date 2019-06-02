using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Burbujas : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private BoxCollider2D bc2d;
    private Rigidbody2D rb2dItem;
    public GameObject ItemInterior;
    [Range(1, 5)]
    public int resistencia;

    private void Awake()
    {
         
    }
   
    void Start()
    {
        resistencia = 4; 
    }

    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        bc2d = GetComponent<BoxCollider2D>();
        rb2dItem = ItemInterior.GetComponent<Rigidbody2D>();
        resistencia = resistencia - 1;
        Debug.Log(resistencia); 
        if (resistencia <= 0)
        {
            bc2d.enabled = false;
            rb2dItem.bodyType = RigidbodyType2D.Dynamic;
            
        }
    }



}
