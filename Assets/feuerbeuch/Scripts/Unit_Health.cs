using UnityEngine;
using System.Collections.Generic;
using UnityEngine.Networking;
using UnityEngine.UI;

public class Unit_Health : NetworkBehaviour {


	[SyncVar] private string health = "100";
	[SerializeField] private string Health = "100";

	//Use this for initialization
	void Start()
	{

	}

	//Update is called once per frame
	void Update (){

	}
	

	void SetHealthText()
{
	if(isLocalPlayer)
	{
		
	}
}



}
