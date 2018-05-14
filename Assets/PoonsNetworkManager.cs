using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class PoonsNetworkManager : NetworkManager {

	public Text dotsText;

    

		public void Start(){
		dotsText.text = "Ploppy plop";
	}

	public void MyStartHost(){
		StartHost ();
		Debug.Log (System.DateTime.Now + " : *PoonHost start request*");
	}


	public override void OnStartHost(){
		Debug.Log (System.DateTime.Now + " : *PoonHost started* " );
	}


	public override void OnStartClient(NetworkClient poonNMClient){
		Debug.Log (System.DateTime.Now + " : *PoonNetMan client start request* ");
		InvokeRepeating ("Dots", 0.1f, 1f);
	}


	public override void OnClientConnect(NetworkConnection PNMconn){
		Debug.Log (System.DateTime.Now + " : *PooNetMan client connected* : " + PNMconn.address);
		CancelInvoke ("Dots");
	}

	void Dots(){
		dotsText.text += ".";
	}

}
