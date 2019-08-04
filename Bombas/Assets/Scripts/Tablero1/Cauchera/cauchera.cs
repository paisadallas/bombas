using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// *****Lo ubicamos en nuestra Roca ****

public class cauchera : MonoBehaviour
{
    private bool press;
    public bool cargado;

    private Rigidbody2D rb2d;
    private SpringJoint2D sj2d;    
    private LineRenderer lr;    
    public GameObject punto1;
    public GameObject punto2;
    private Rigidbody2D rb2dP1;
    private Rigidbody2D rb2dP2; 
    private AudioSource apuntando;
    bool enableAudio;

    // point 1


    void Start()
    {
        cargado = true;
        press = true;
        lr = GetComponent<LineRenderer>();        
        lr.enabled = true;
        enableAudio = true;       
        rb2dP1 = punto1.GetComponent<Rigidbody2D>();
        rb2dP2 = punto2.GetComponent<Rigidbody2D>();
        apuntando = GetComponent<AudioSource>();

       
        
    }

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        sj2d = GetComponent<SpringJoint2D>();     
    }

    // Update is called once per frame
    void Update()
    {
      //  LineaRenderPosition();
        if (press && cargado == true)
        {
            arrastrarBola();         
        }      
    }

    private void arrastrarBola()
    {
        if (press)
        {
            LineaRenderPosition(); //Descomentarear 
        } 
    }

    private void miSonido()
    {
        if (enableAudio)
        {
            apuntando.Play();
            enableAudio = false;
        } 
    }

    private void LineaRenderPosition()
    {
        Vector3[] positions = new Vector3[3]; 
        
        positions[0] = rb2dP1.position;
        positions[1] = rb2d.position;
        positions[2] = rb2dP2.position;
        lr.SetPositions(positions);        
    } 


    private void OnMouseDown()
    {
        miSonido();
        press = true;
    }
    // proyectil lanzado objeto lanzado
    private void OnMouseUp()
    {     
        lr.enabled = false;       
        apuntando.Stop();  // sonido      
    }
}
