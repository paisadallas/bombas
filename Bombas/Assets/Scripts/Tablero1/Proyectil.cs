using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
{
   
    private Rigidbody2D rb2d;
    private SpringJoint2D sj2d;
    private bool press;
    private float relaseDealy;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        sj2d = GetComponent<SpringJoint2D>();

        relaseDealy = 1 / (sj2d.frequency * 4);
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
        rb2d.position = mousePosition;
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
    }

    private IEnumerator Release()
    {
        yield return new WaitForSeconds(relaseDealy);
        sj2d.enabled = false;
       
    }
}
