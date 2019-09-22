using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Arrastrar : MonoBehaviour, IDragHandler 
{
    //NOTA ----  Aplicar scrip a mi imagen y no a mi canvas
    // ---- los canvas tiene un EventSystem

    public GameObject disparador;
    private Transform transDisparador,canvas;
    public Contador miContador;
    [Range(0.0f,3.0f)]
    public float rangoX=1.33f;
    private float rangoY;
       
    
    private float delay;
    
    void Start()
    {
        disparador.SetActive(false);  // inicialmente Desactivado
        canvas = GetComponent<Transform>();    //mi disparador          
        rangoY = canvas.position.y;
    }


    // Arrastrar mi objeto
    public void OnDrag(PointerEventData eventData)
   
    {           
        Vector3 miPosicion = Camera.main.ScreenToWorldPoint(eventData.position);
       
         
        coordenadasPosicion(miPosicion.x);
         
    }
  
    //Suelto el objeto
    private void OnMouseUp()
    {
        delay = 0.0f;   // objeto ubicado con un delay (problema que surgio) 0.38f
        canvas = GetComponent<Transform>();
        float posicion = canvas.position.x;
        transDisparador = disparador.GetComponent<Transform>();
        transDisparador.position = new Vector3(posicion-delay, rangoY,1000.0f);   //rango Y = -7.0
        disparador.SetActive(true);
        // Destroy(gameObject);
        this.gameObject.SetActive(false);
        miContador.resetContador();     
                                                                          
    }

    private void coordenadasPosicion(float posicionX)
    {                                  
        if (posicionX <= -rangoX)
        {
            posicionX = -rangoX;
        }
        if (posicionX >= rangoX)
        {
            posicionX = rangoX;
        }

        transform.position = new Vector3(posicionX, rangoY,1000.0f);  
    }
}
