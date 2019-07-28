using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//******Aplicamos a nuestra roca Evitar ser disparado cuando tenesmos nuestro cofre abierto  *****

public class UnaEna : MonoBehaviour
{
    
    public GameObject panelTimeEnd;
    public GameObject panelCofre;
    private Rigidbody2D velocidad;
    float VelX;

    private void Start()
    {
        velocidad = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        VelX = velocidad.velocity.x;  
        

        if (panelTimeEnd.activeSelf)  //destruimos roca termina tiempo disparo
        {
            Destroy(gameObject);
        }

        if (panelCofre.activeSelf && VelX==0) // objeto esta quieto
        {
            gameObject.layer = 10;    //Layer No renderizadoPor la camara
        }

        if (!panelCofre.activeSelf)
        {
            gameObject.layer = 8;
        }
    }

}
