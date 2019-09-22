using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//**************  Agregamos a nuestro contador de poderes   ****************////
public class QtyPoder : MonoBehaviour
{
    public TextMeshProUGUI poderX1;
    public TextMeshProUGUI poderX2;
    public TextMeshProUGUI poderX3;
    public TextMeshProUGUI poderX4;
    float disponibles;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        disponibles = DisparosExtras.extras;
        poderX1.text =  Boom.boom.ToString("f0");
        poderX2.text =  BoomX2.boomX2.ToString("f0");
        poderX3.text =  MisRocks.roca.ToString("f0");
        poderX4.text = Ver.ver.ToString("f0");
        //poderX1.text = "x" + disponibles.ToString("f0");
    }
}
