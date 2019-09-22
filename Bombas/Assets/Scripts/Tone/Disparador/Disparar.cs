using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Disparar : MonoBehaviour, IDragHandler, IEndDragHandler    //Mover y soltar objetos
{
    private Rigidbody2D rb2d;
    private Rigidbody2D slingRb;
    private SpringJoint2D sj2d;
    private LineRenderer lr;
    private float relaseDealy;
    private float disMax = 1.2f;
    public bool press;
 
    void Start()
    {
        rb2d.isKinematic = true;
        press = false;
    }

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        sj2d = GetComponent<SpringJoint2D>();
        slingRb = sj2d.connectedBody;
        relaseDealy = 1 / (sj2d.frequency * 4);   // separar objeto en un tiempo x
        lr = GetComponent<LineRenderer>();
    }


    public void OnDrag(PointerEventData eventData)
    {

        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float distance = Vector2.Distance(mousePosition, slingRb.position);
      
        rb2d.position = mousePosition  ;
        if (distance > disMax)
        {
            Vector2 direction = (mousePosition - slingRb.position).normalized;
            rb2d.position = slingRb.position + direction * disMax;
        }

    }  
  
        public void OnEndDrag(PointerEventData eventData)
    {
       
        rb2d.isKinematic = false;
        StartCoroutine(Release());
    }

    private IEnumerator Release()
    {
        yield return new WaitForSeconds(relaseDealy);
        sj2d.enabled = false;
        rb2d.isKinematic = false;
        lr.enabled = false;
    }

    private void OnMouseUp()
    {
        Debug.Log("Soltado");
        //press = false;
        //rb2d.isKinematic = false;
        //StartCoroutine(Release());
        //cargado = false;
        //rb2d.constraints = RigidbodyConstraints2D.None;  // proyectil puede girar

    }

    private void OnMouseDown()
    {
       // rb2d.isKinematic = true;
        press = true;
        
        
    }


}
