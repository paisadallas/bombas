using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Contador : MonoBehaviour
{
    public Text contador;
   // public GameObject proyectil;
   // private CircleCollider2D enableProyectil;
    private float tiempo = 10f;
    private bool estado;
    public Proyectil miProyectil;
    void Start()
    {
        contador.text = "" + tiempo;
        estado = true;
        //enableProyectil = proyectil.GetComponent<CircleCollider2D>();
        //enableProyectil.enabled = true;
       
    }

    public void finContador(bool fin)
    {
        if (!fin)
        {
            contador.enabled = false;
            estado = false;
        }
    }

    public void resetContador()
    {
        tiempo = 10f;
        //enableProyectil = proyectil.GetComponent<CircleCollider2D>();
        //enableProyectil.enabled = true;
    }
    // Update is called once per frame
    void Update()
    {
        conteo(estado);
        finContador(miProyectil.cargado);
    }

   private void conteo(bool estado)
    {       
            if (estado)
            {
            tiempo -= Time.deltaTime;
            }
            
            contador.text = " " + tiempo.ToString("f0");

            if (tiempo <= 0)
            {
          //      Debug.Log("PierdeNivel");

            }
                 
   
    }

  
}
