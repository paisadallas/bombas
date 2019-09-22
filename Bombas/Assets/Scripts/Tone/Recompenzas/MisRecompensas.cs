using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MisRecompensas //No heredamos
{
    public void Roca(int qty)
    {

        MisRocks masUno = new MisRocks(qty);
    }

    public void Boom(int qty)
    {
        Boom masUno = new Boom(qty);
    }

    public void BoomX2(int qty)
    {
        BoomX2 masUno = new BoomX2(qty);
    }

    public void Ver(int qty)
    {
        Ver ver = new Ver(qty);
    }
}
