using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValidarPlayer : MonoBehaviour
{
    public GameObject playerL;
    public GameObject playerR;     
    private Transform tf;
  

    void Start()
    {
        tf = GetComponent<Transform>();
        funcion();        
    }

    void funcion()
    {
        
            if (tf.transform.position.x > 0)
            {
                playerL.SetActive(true);
            }
            if (tf.transform.position.x <= 0)
            {
                playerR.SetActive(true);
            } 
        }       

   

}
