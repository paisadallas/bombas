using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseSprite : MonoBehaviour
{
    public Sprite rockXNormal;
    public Sprite rockXR1;
    public Sprite rockXR3;     
    private SpriteRenderer spr;     
    [Range(0,2)]
    public int idRock;
    public PoderActual poderActual;
    void Start()
    {
        idRock = 0;
        
        spr = gameObject.GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        //   this.gameObject.GetComponent<SpriteRenderer>().sprite = spActual;
        // spr.sprite = rockXR1;
        idRock =poderActual.poderActual;
        switch (idRock)
        {
            case 0:
                this.gameObject.GetComponent<SpriteRenderer>().sprite = rockXNormal;
                break;
            case 1:
                this.gameObject.GetComponent<SpriteRenderer>().sprite = rockXR1;
                break;

            case 2:
                this.gameObject.GetComponent<SpriteRenderer>().sprite = rockXR3;
                break;
        }
    }
      
    void OnTriggerEnter2D(Collider2D otro)
    {
        //Generamos Nuevo proyectil
        if (otro.gameObject.tag == "Proyectiles")
        {
            poderActual.poderActual = 0;   //Reiniciamos nuestro Sprite
        }
    }

}
