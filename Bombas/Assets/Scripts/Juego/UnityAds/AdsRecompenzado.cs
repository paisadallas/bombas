using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;   //trabajar con los anuncios
using UnityEngine.SceneManagement;

public class AdsRecompenzado : MonoBehaviour
{

    

    string placementID = "rewardedVideo"; //ID del anuncio
    void Start()
    {
        Advertisement.Initialize(placementID);
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
            //gemns += rewardGemns;
            //txtGemns.text = gemns.ToString();
            ReplayLevel();

        }
        else if (result == ShowResult.Skipped)
        {
            print("REWARDED - Video salteado.");
            //txtMessage.text = "REWARDED - Video salteado.";
        }
        else if (result == ShowResult.Failed)
        {
            print("REWARDED - Falla al cargar el video.");
            //txtMessage.text = "REWARDED - Falla al cargar el video.";
        }
    }

    private void ReplayLevel()
    {
        SceneManager.LoadScene("TableroUno");    //Cargo mi escena de nuevo
        NoProyectiles.disparos = 0;   // Reinicio mis diparos
        Puntos.logros = 0;              //Reinicio Puntos
        Marcador.miMarcador = 0;       
        DisparosExtras miMarcador = new DisparosExtras(); // Agg Disparo
    }
}
