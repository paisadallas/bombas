using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guion : MonoBehaviour
{
    public GameObject manito;  // roca
    public GameObject manito2; // burbuja
    public GameObject manito3; // obstaculo
    public GameObject manito4; // obstaculo 2
    public GameObject roca;
    public GameObject burbuja1;
    public GameObject burbuja2;
    public GameObject obstaculo;
    public GameObject obstaculo2;
    private Animator animator;
    private Rigidbody2D rb2d;
    private bool boolManito;
    public Burbujas burbujas;
    public Burbujas burbujasDos;
    public Golpes obsta;
    public Golpes obstaDos;
    // Start is called before the first frame update
    void Start()
    {
        animator = manito.GetComponent<Animator>();
        rb2d = roca.GetComponent<Rigidbody2D>();
        boolManito = true;
    }

    // Update is called once per frame
    void Update()
    {
        Manito();
        Manito2();
        Burbuja();
    }
    
    private void Manito()
    {
        if (roca.activeSelf)
        {               
            animator.Play("disparar");
        }

        if (rb2d.isKinematic)
        {
            manito.SetActive(false);
        }
       
    }

    private void Manito2()
    {
        if (roca.activeSelf)
        {               
            manito2.SetActive(true);
            if (boolManito)
            {
                boolManito = false;
                burbuja1.SetActive(true);  
            }

        }
    }

    private void Burbuja()
    {
        if (burbujas.resistencia<=0)
        {               
            obstaculo.SetActive(true);
            manito2.SetActive(false);
            manito3.SetActive(true);
        }

        if(obsta.resistencia <= 0)
        {
            obstaculo2.SetActive(true);
            manito3.SetActive(false);
            manito4.SetActive(true);
        }

        if (obstaDos.resistencia <= 0)
        {
            manito4.SetActive(false);
            if (burbujasDos.resistencia > 0)
            {
                burbuja2.SetActive(true);
            }
            
        }
    }  
   
}
