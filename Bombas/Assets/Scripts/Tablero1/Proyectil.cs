﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Se aplica a nuestro proyectil (al igual que GenerarProyectil.cs)
public class Proyectil : MonoBehaviour
{
    
    private Rigidbody2D rb2d;
    private Rigidbody2D slingRb;
    private SpringJoint2D sj2d;
    private bool press;
    private float relaseDealy;
    private float disMax = 1.2f;   
        
    public bool cargado; 
    private LineRenderer lr;
    private void Start()
    {
        sj2d.enabled = true;
             
        cargado = true;
        rb2d.constraints = RigidbodyConstraints2D.FreezePositionX;     //Evito que mi proyectil gire
        rb2d.constraints = RigidbodyConstraints2D.FreezePosition;
        rb2d.constraints = RigidbodyConstraints2D.FreezeAll;

        lr = GetComponent<LineRenderer>();          
    }

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        sj2d = GetComponent<SpringJoint2D>();
        slingRb = sj2d.connectedBody;
        relaseDealy = 1 / (sj2d.frequency * 4);   // separar objeto en un tiempo x 
             
    }
    void Update()
    {
        if (press && cargado==true)
        {
            arrastrarBola();
        }
    }      
    private void arrastrarBola()
    {
        if (press)
        {
          //  LineaRenderPosition();
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            float distance = Vector2.Distance(mousePosition, slingRb.position);
            rb2d.position = mousePosition;

            if (distance > disMax)
            {
                Vector2 direction = (mousePosition - slingRb.position).normalized;
                rb2d.position = slingRb.position + direction * disMax;
            }

        }            
    }

    private void LineaRenderPosition()
    {
        Vector3[] positions = new Vector3[2];
        positions[0] = rb2d.position;
        positions[1] = slingRb.position;
        lr.SetPositions(positions);
    }
    //proyectil en disparador  objeto en catapulta
    
    private void OnMouseDown()
    {
        rb2d.isKinematic = true;
        press = true;
    }
    // proyectil lanzado objeto lanzado
    private void OnMouseUp()
    {
        press = false;
        rb2d.isKinematic = false;
        StartCoroutine(Release());
        cargado = false;
        rb2d.constraints = RigidbodyConstraints2D.None;  // proyectil puede girar

    }
    // permite arrastrar mi proyectil
    private IEnumerator Release()
    {
        yield return new WaitForSeconds(relaseDealy);
        sj2d.enabled = false;
        lr.enabled = false;
    }
    
}
