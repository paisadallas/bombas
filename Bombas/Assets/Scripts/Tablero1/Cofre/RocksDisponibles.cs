using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RocksDisponibles : MonoBehaviour
{
    //Nos indica cuantas rocas tenemos ///
    //Aplicamos en nuestro canvas TextQuaility///

    public Text rocasNormal;
    public Text rocasX1;
    public Text rocasX3;

    void Start()
    {
        rocasNormal.text = "" + Rock.roca;
        rocasX1.text = "" + RockX1.roca;
        rocasX3.text = "" + RockX3.roca;
    }

    // Update is called once per frame
    void Update()
    {
        RockNormal();
        RockPoder1();
        RockPoder2();
    }
     
    private void RockNormal()
    {
        if (Rock.roca == 0)
        {
            rocasNormal.text = "";
        }
        else
        {
            rocasNormal.text = "+" + Rock.roca;
        }
    }

    private void RockPoder1()
    {
        if (RockX1.roca == 0)
        {
            rocasX1.text = "";
        }
        else
        {
            rocasX1.text = "+" + RockX1.roca;
        }
    }

    private void RockPoder2()
    {
        if (RockX3.roca == 0)
        {
            rocasX3.text = "";
        }
        else
        {
            rocasX3.text = "+" + RockX3.roca;
        }
    }

}
