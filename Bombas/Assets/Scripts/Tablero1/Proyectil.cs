using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
{
   
    private Rigidbody2D rb2d;
    private Rigidbody2D slingRb;
    private SpringJoint2D sj2d;
    private bool press;
    private float relaseDealy;
    private float disMax = 2f;
    public Contador miContador;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        sj2d = GetComponent<SpringJoint2D>();
        slingRb = sj2d.connectedBody;
        relaseDealy = 1 / (sj2d.frequency * 4);   // separar objeto en un tiempo x

    }
    void Update()
    {                   
        if (press)
        {
            arrastrarBola();  
        }                       
    }

    private void arrastrarBola()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float distance = Vector2.Distance(mousePosition, slingRb.position);
        rb2d.position = mousePosition;

        if(distance> disMax) {
            Vector2 direction = (mousePosition - slingRb.position).normalized;
            rb2d.position = slingRb.position + direction * disMax;
        }
        else
        {

        }
    }

    private void OnMouseDown()
    {
        press = true;
        rb2d.isKinematic = true;
        
    }

    private void OnMouseUp()
    {
        press = false;
        rb2d.isKinematic = false;
        StartCoroutine(Release());
        miContador.finContador();
      
    }

    private IEnumerator Release()
    {
        yield return new WaitForSeconds(relaseDealy);
        sj2d.enabled = false;
       
    }
}
