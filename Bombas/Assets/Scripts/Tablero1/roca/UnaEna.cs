using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//******Aplicamos a nuestra roca Evitar ser disparado cuando tenesmos nuestro cofre abierto  *****

public class UnaEna : MonoBehaviour
{
    
    public GameObject panelWinner;
    public GameObject panelPause;
    


    private void Start()
    {
      
    }
    // Update is called once per frame
    void Update()
    {         

        if (panelPause.activeSelf) // objeto esta quieto
        {
         this.gameObject.layer = 10;    //Layer No renderizadoPor la camara                                                    
        }

        if (!panelPause.activeSelf)
        {
            gameObject.layer = 8;         
           
        }

        if (panelWinner.activeSelf) // objeto esta quieto
        {
            this.gameObject.layer = 10;    //Layer No renderizadoPor la camara                                                    
        }
       

    }

}
