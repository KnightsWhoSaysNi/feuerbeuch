using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class Player_NetworkSetup : NetworkBehaviour {
	
	
	
	// Use this for initialization
	void Start ()
	{
		if(isLocalPlayer)
		{		
			
			GetComponent<UnityStandardAssets._2D.Platformer2DUserControl>().enabled=true;
			GetComponent<UnityStandardAssets._2D.PlatformerCharacter2D>().enabled=true;
		}
	}
}
// Update is called once per frame
