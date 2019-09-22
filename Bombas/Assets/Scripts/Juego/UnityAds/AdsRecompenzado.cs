using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;   //trabajar con los anuncios
using UnityEngine.SceneManagement;

public class AdsRecompenzado : MonoBehaviour
{
   
    private Scene scene;
    private string placementID = "rewardedVideo"; //ID del anuncio
    public TipoPremio boom;
    public TipoPremio boomX2;
    public TipoPremio roca;
    public TipoPremio ver;
    private int cantidad;
    void Start()
    {   
        Advertisement.Initialize(placementID);
        scene = SceneManager.GetActiveScene();
    }

    public void ShowRewardedVideo()
    {
        //ShowOptions es una coleccion que nos permite trabajar con los diferentes resultados del video
        ShowOptions options = new ShowOptions();

        //Devolución de llamada para recibir el resultado del anuncio.
        options.resultCallback = HandleShowResult;

        //Si esta listo, muestra el video
        if (Advertisement.IsReady(placementID))
        {
            Advertisement.Show(placementID, options);
            print("REWARDED - Video abierto.");
          //  txtMessage.text = "REWARDED - Video abierto.";
        }
        else
        {
            print("El Video Recompensado aun no esta listo.");
           // txtMessage.text = "El Video Recompensado aun no esta listo.";
        }
    }

    void HandleShowResult(ShowResult result)
    {
        if (result == ShowResult.Finished)
        {
            print("REWARDED - Recompensado.");
            //txtMessage.text = "REWARDED - Recompensado.";
           
            //aqui agrego la recompensa 

            seleccionPublicidad();


        }
        else if (result == ShowResult.Skipped)
        {
            print("REWARDED - Video salteado.");
            
            //txtMessage.text = "REWARDED - Video salteado.";
            ReplayLevel();
           
        }
        else if (result == ShowResult.Failed)
        {
            print("REWARDED - Falla al cargar el video.");
            //txtMessage.text = "REWARDED - Falla al cargar el video.";
            ReplayLevel();
           
        }
    }

    private void seleccionPublicidad()
    {
        MisRecompensas agg = new MisRecompensas();
        Cantidad();
        if (boom.boom && boom.activado)
        {
            agg.Boom(boom.cantidad);
        }
        if (boomX2.boomX2 && boomX2.activado)
        {
            //BoomX2 add = new BoomX2(cantidad);
            agg.BoomX2(boomX2.cantidad);
        }        
        if (roca.rock && roca.activado)
        {
            agg.Roca(roca.cantidad);
        }
        if (ver.ver && ver.activado)
        {
            agg.Ver(ver.cantidad);
        }

    }

    public void ReplayLevel()
    {
        SceneManager.LoadScene(scene.name);    //Cargo mi escena de nuevo
        NoProyectiles.disparos = 0;   // Reinicio mis diparos
        Puntos.logros = 0;              //Reinicio Puntos
        Marcador.miMarcador = 0;
    } 

    private void Cantidad()
    {
        cantidad = (LostLevel.no % 2) + 1;
    }

}
