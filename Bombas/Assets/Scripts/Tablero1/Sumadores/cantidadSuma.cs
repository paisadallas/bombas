using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cantidadSuma : MonoBehaviour
{
    public Sprite MasUno;
    public Sprite MasDos;
    private SpriteRenderer image;
    // Start is called before the first frame update
    void Start()
    {
       image = gameObject.GetComponent<SpriteRenderer>();

    }

    private void Update()
    {
        if(LostLevel.no == 2 || LostLevel.no == 4 || LostLevel.no == 6)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = MasUno;
        }
        else
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = MasDos;
        }
       
    }

}
