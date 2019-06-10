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
    private float rangoX=3.0f;
       
    [Range(0, 10)]
    public float delay;
    
    void Start()
    {
        disparador.SetActive(false);  // inicialmente Desactivado
        canvas = GetComponent<Transform>();    //mi disparador
        canvas.position = new Vector3(0, -7, 0);      //posicion inicial
        
    }


    // Arrastrar mi objeto
    public void OnDrag(PointerEventData eventData)
   
    {           
        Vector3 miPosicion = Camera.main.ScreenToWorldPoint(eventData.position);
         
        coordenadasPosicion(miPosicion.x);
         
    }
  
    private void OnMouseUp()
    {
        delay = 0.38f;   // objeto ubicado con un delay (problema que surgio)
        canvas = GetComponent<Transform>();
        float posicion = canvas.position.x;
        transDisparador = disparador.GetComponent<Transform>();
        transDisparador.position = new Vector2(posicion-delay, -7);
        disparador.SetActive(true);
        Destroy(gameObject);
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

        transform.position = new Vector3(posicionX, -7,0);  
    }
}
