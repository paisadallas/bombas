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
    private int bolas;
    // Start is called before the first frame update
    void Start()
    {

        contador.text = ""+ disponibles; 

    }

    private void Update()
    {
        
        contador.text = "" + MisDisparos();

    }

    private int MisDisparos()
    {
        return bolas = disponibles - NoProyectiles.disparos;
    }


}
