using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


// aplicamos en nuestro objeto que queremos arrastrar (Activar Video)
public class BtRecompenza : MonoBehaviour, IDragHandler
{
    private Transform canvas;
    private float rangoY;
    private float rangoX;

    private void Start()
    {
        canvas = GetComponent<Transform>();    //mi disparador
        rangoY = canvas.position.y;
        rangoX = 2.5f;
        
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector3 miPosicion = Camera.main.ScreenToWorldPoint(eventData.position);       
        coordenadasPosicion(miPosicion.x);
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

        transform.position = new Vector3(posicionX, rangoY,30);
    }


}
