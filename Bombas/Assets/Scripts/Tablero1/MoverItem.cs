using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//****** Aplicamos a nuestro item Interior ********
public class MoverItem : MonoBehaviour
{

    private Transform transItem;
    private CircleCollider2D cc2dItem;
    Vector3 posEnd;     
    [Range(0f,25f)]
    public float y;
    
    void Start()
    {
        posEnd = new Vector3(-5.23f,9.6f,0.0f);
       
        transItem = GetComponent<Transform>();
        cc2dItem = GetComponent<CircleCollider2D>();
    }   
    // Update is called once per frame
    void Update()
    {
       // posFinal();

        if (cc2dItem.isTrigger)
        {
            Debug.Log("Mover Item");
            // Pos rigiBody2D
            transItem.position = Vector3.Lerp(transItem.position, posEnd, 0.1f);    //transladamos mi objeto
        }
    }

   

    
}
