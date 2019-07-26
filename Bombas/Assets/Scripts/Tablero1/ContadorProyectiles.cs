using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//**** Aplicamos al canvas NoProyectiles (cuenta el numero de proyectiles dispobibles) *****
public class ContadorProyectiles : MonoBehaviour
{
    public Text contador;
    [Range(0,10)]
    public int disponibles; 
    public int bolas;
    [Range(0, 10)]
    
    public int extras;

    void Start()
    {    
        contador.text = ""+ disponibles;
        extras = DisparosExtras.extras;
    }

    private void Update()
    {          
        contador.text = "" + MisDisparos();  
    }

    private int MisDisparos()
    {
        return bolas =Extras(extras)+ disponibles - NoProyectiles.disparos;
    }

    private int Extras(int extras)
    {
        if (extras <= 0)
        {
            extras = 0;
        }

        return extras;
    }
}
