using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//***** Se aplica al boton de repetir nivel *****

public class Replay : MonoBehaviour
{

    public void ReplayLevel()
    {    
        SceneManager.LoadScene("TableroUno");    //Cargo mi escena de nuevo
        NoProyectiles.disparos = 0;   // Reinicio mis diparos
        Puntos.logros = 0;              //Reinicio Puntos
        Marcador.miMarcador = 0;
        DisparosExtras.extras = 0; // sin disparos extras
    }
}
