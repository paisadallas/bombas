using UnityEngine;
using UnityEngine.Advertisements;   //trabajar con los anuncios
using UnityEngine.UI;

public class UnityADSRewardedVideo : MonoBehaviour {

	string placementID = "rewardedVideo"; //ID del anuncio
	public Text txtMessage;
	public Text txtGemns;
	[Range(0, 10)]public int rewardGemns;
	int gemns;

	void Start () {
		// Inicia el SDK de Unity Ads
		//Advertisement.Initialize (placementID, true); //El TRUE es para activar el Modo Testeo
		Advertisement.Initialize (placementID);

		//Setea las gemas y el texto a CERO
		gemns = 0;
		txtGemns.text = gemns.ToString ();
	}

	//Muestra el Video Recompensado, si esta listo
	public void ShowRewardedVideo () {
		//ShowOptions es una coleccion que nos permite trabajar con los diferentes resultados del video
		ShowOptions options = new ShowOptions ();

		//Devolución de llamada para recibir el resultado del anuncio.
		options.resultCallback = HandleShowResult;

		//Si esta listo, muestra el video
		if (Advertisement.IsReady(placementID)) {
			Advertisement.Show (placementID, options);
			print ("REWARDED - Video abierto.");
			txtMessage.text = "REWARDED - Video abierto.";
		} else {
			print ("El Video Recompensado aun no esta listo.");
			txtMessage.text = "El Video Recompensado aun no esta listo.";
		}
	}

	void HandleShowResult (ShowResult result) {
		if (result == ShowResult.Finished) {
			print ("REWARDED - Recompensado.");
			txtMessage.text = "REWARDED - Recompensado.";
			gemns += rewardGemns;
			txtGemns.text = gemns.ToString ();
		} else if (result == ShowResult.Skipped) {
			print ("REWARDED - Video salteado.");
			txtMessage.text = "REWARDED - Video salteado.";
		} else if (result == ShowResult.Failed) {
			print ("REWARDED - Falla al cargar el video.");
			txtMessage.text = "REWARDED - Falla al cargar el video.";
		}
	}

}
