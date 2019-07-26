using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

 //*********CUENTA REGRESIVA**********
// Se aplica a un GameObjet Contador el cual contiene un contador con un Text(Script)
public class Contador : MonoBehaviour
{
    public Text contador;    
    private float tiempo = 10f;
    private bool estado;
    public Proyectil miProyectil;
    public GameObject panelLost;
   // public GameObject panelPause;
    
    void Start()
    {
        contador.text = "" + tiempo;
        estado = true;        
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
            //Perdemos nivel si no ubicamos             
            finContador(false);
            panelLost.SetActive(true);
            }     
   
    }

  
}
