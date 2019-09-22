using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


// aplicamos en nuestro objeto que queremos arrastrar (Activar Video)
public class BtRecompenza : MonoBehaviour, IDragHandler
{
    private Transform canvas;
    public float rangoY;
    public float rangoX;

    private void Start()
    {
        canvas = GetComponent<Transform>();    //mi disparador
        rangoY = canvas.position.y;
        rangoX = 1.23f;
        
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector3 miPosicion = Camera.main.ScreenToWorldPoint(eventData.position);       
        coordenadasPosicion(miPosicion);
    }

    private void coordenadasPosicion(Vector2 posicionX)
    {
        if (posicionX.x <= -rangoX)
        {
            posicionX.x = -rangoX;
        }
        if (posicionX.x >= rangoX)
        {
            posicionX.x = rangoX;
        }

        transform.position = new Vector3(posicionX.x, rangoY,30);
    }


}
