using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerScenes : MonoBehaviour
{
    private Scene scene;
    private void Start()
    {
        scene = SceneManager.GetActiveScene();
    }
    public void SceneActual()
    {
        SceneManager.LoadScene(scene.name);    //Cargo mi escena de nuevo
    }

   public void sceneMenu()
    {
        SceneManager.LoadScene("MenuInicio");
    } 
    
    public void scenesTablero1()
    {
        SceneManager.LoadScene("Tone");
    }

    public void resetData()
    {
        NoProyectiles.disparos = 0;   // Reinicio mis diparos
        Puntos.logros = 0;              //Reinicio Puntos
        Marcador.miMarcador = 0;       // reinicio mi marcador
        LostLevel.no = 0;
    }

}
