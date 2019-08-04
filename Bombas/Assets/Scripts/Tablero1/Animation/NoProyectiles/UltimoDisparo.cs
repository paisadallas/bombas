using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//aplicamos al texto del ultimo disparo///

public class UltimoDisparo : MonoBehaviour
{
    private Animator animator;
    public ContadorProyectiles contadorProyectiles;
    private int proyectiles;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        proyectiles = contadorProyectiles.bolas;
    }

    // Update is called once per frame
    void Update()
    {
        proyectiles = contadorProyectiles.bolas; 

                                                     //Si nos queda el ultimo proyectil///
        animator.SetInteger("ultimo", proyectiles);  //activamos nuestra animacion
    }
}
