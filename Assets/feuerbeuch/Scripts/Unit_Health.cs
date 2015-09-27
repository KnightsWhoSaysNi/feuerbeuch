using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
using UnityEngine.UI;

public class Unit_Health : NetworkBehaviour {

	[SyncVar(hook = "OnHealthChanged")] private int health = 100;
	private Text HealthText;

	//Use this for initialization
	void Start()
	{
		HealthText = GameObject.Find ("Player 1 - Melee HP").GetComponent<Text>();
		SetHealthText();
	}

	//Update is called once per frame
	void Update (){

	}
	

	void SetHealthText()
{
	if(isLocalPlayer)
	{
		HealthText.text = "Health" + health.ToString();
	}
}
	public void DeductHealth (int dmg)
	{
	health -= dmg;
	}

	void OnHealthChanged(int hlth)
	{
		health = hlth;
		SetHealthText ();
	}
}
