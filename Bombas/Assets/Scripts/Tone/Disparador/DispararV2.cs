using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DispararV2 : MonoBehaviour
{
  //  private Rigidbody2D rb2d;
  //  private Rigidbody2D slingRb;
  ////  private SpringJoint2D sj2d;
  //  private float relaseDealy;
  //  private bool press;
  //  public bool cargado;
  //  private float disMax = 1.2f;

  //  void Start()
  //  {
        
  //  }
 
  //  // Update is called once per frame
  //  void Update()
  //  {
  //      if (press)
  //      {
  //          arrastrarBola();
  //      }       
  //  }

  //  private void arrastrarBola()
  //  {
  //      if (press)
  //      {                
  //          Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
  //          float distance = Vector2.Distance(mousePosition, slingRb.position);
  //          rb2d.position = mousePosition;

  //          if (distance > disMax)
  //          {
  //              Vector2 direction = (mousePosition - slingRb.position).normalized;
  //              rb2d.position = slingRb.position + direction * disMax;
  //          }  
  //      }
  //  }

  //  private void OnMouseDown()
  //  {          
  //      press = true;
  //      Debug.Log("click");
  //  }

  //  private void OnMouseUp()
  //  {
  //      press = false;
  //      Debug.Log("click");
  //  }

}
