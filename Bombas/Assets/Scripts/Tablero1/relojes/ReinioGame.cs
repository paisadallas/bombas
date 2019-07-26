using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// *****se aplica a objeto cronometro de nuestro panel lost level****

public class ReinioGame : MonoBehaviour
{
    private float tiempo;
    private bool estado;
    [Range(0, 10)]
    public float TimeReplay;

    private void Start()
    {
        tiempo = 0;
        estado = true;
    }

    // Update is called once per frame
    void Update()
    {
        conteo(estado);
    }

    private void conteo(bool estado)
    {
        if (estado)
        {
            tiempo += Time.deltaTime;
        }

        if (tiempo >= TimeReplay)
        {
            ReplayLevel();
        }
    }

    public void ReplayLevel()
    {
        SceneManager.LoadScene("TableroUno");    //Cargo mi escena de nuevo
        NoProyectiles.disparos = 0;   // Reinicio mis diparos
        Puntos.logros = 0;              //Reinicio Puntos
        Marcador.miMarcador = 0;
        DisparosExtras.extras = 0; // sin disparos extras
    }
}
