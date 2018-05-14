using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.Networking;

public class PlayerControl : NetworkBehaviour {

	private Vector3 playerMovement;
	private Camera thisCamera;

	// X axis <---- ---->
	// Z axis In Out
	// Y axis up (higher) down (lower)

	void Start () {
		

	}


	void CheckInput ()
	{
		playerMovement.x = CrossPlatformInputManager.GetAxis ("Horizontal");
		playerMovement.y = 0f;
		playerMovement.z = CrossPlatformInputManager.GetAxis ("Vertical");


		if (isLocalPlayer) {
			
			transform.Translate (playerMovement);
		}
	}


	// Update is called once per frame
	void Update () {
		CheckInput ();
	

	}

	public override void OnStartLocalPlayer ()
	{
		thisCamera = GetComponentInChildren<Camera> ();
		thisCamera.enabled = true;
	}



}
