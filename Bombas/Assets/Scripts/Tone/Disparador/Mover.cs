using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

//Lo aplicamos a nuestra Planta

public class Mover : MonoBehaviour, IDragHandler ,IEndDragHandler
{
    private RectTransform posY;
    private Rigidbody2D rb2d;
    private float limitles;
    private bool confirmar;     
    public GameObject roca;
    public GameObject jirafa;
    
    private void Start()
    {
        posY = GetComponent<RectTransform>();  //Pos Inicial Y
        limitles = 1.3f;
        confirmar = false;
        roca.SetActive(false);
        jirafa.SetActive(false);         
    }

    public void OnDrag(PointerEventData eventData)
    {       
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);        
        coordenadasPosicion(mousePosition);
    }

 
    private void coordenadasPosicion(Vector2 coordenada)
    {          
        coordenada.y = posY.position.y;
        
        if (coordenada.x < -limitles)
        {
            coordenada.x = -limitles;
        }
        if (coordenada.x > limitles)
        {
            coordenada.x = limitles ;
        }
        if (!confirmar)
        {
            this.transform.position = coordenada;
        }           
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        confirmar = true;
        //se puede introducir sonido 
        roca.SetActive(true);
        jirafa.SetActive(true);          
    }        
}
