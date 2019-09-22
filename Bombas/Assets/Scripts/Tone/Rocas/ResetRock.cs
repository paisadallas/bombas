using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetRock : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private Rigidbody2D slingRb;
    private SpringJoint2D sj2d;
    private CircleCollider2D cc2d;
    private LineRenderer lr;
    private Vector2 resetPos;
    public Proyectil proyectil;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        slingRb = GetComponent<Rigidbody2D>();
        sj2d = GetComponent<SpringJoint2D>();
        lr = GetComponent<LineRenderer>();
        resetPos = rb2d.position;
        cc2d = GetComponent<CircleCollider2D>();
    }

    private void reset()
    {
        transform.position = resetPos;
        lr.enabled = true;
        sj2d.enabled = true;
        rb2d.isKinematic = true;
        rb2d.velocity = new Vector2(0,0);
        proyectil.cargado = true;      
        cc2d.radius = 100;
        NoProyectiles disparos = new NoProyectiles();
    }

    void OnTriggerEnter2D(Collider2D otro)
    {
        if (otro.gameObject.tag == "Proyectiles")
        {
            if(NoProyectiles.disparos +1< TotalDisparos.total + DisparosExtras.extras)   //sumamos el que ya tenemos
            {
                reset();
            }
            else
            {
                NoProyectiles disparos = new NoProyectiles();  
            }
           
        }

    }

    }
