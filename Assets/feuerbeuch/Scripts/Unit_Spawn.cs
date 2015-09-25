using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
public class Unit_Spawn: NetworkBehaviour {
	public GameObject Player1_meleeIns;
	public GameObject Player2_meleeIns;
	public Vector2 player1SpawnPos;
	public Vector2 player2SpawnPos;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Q))
		{
			CmdPlayer1_meleeIns();
			
			
		}

		if(Input.GetKeyDown(KeyCode.P))
		{
			CmdPlayer2_meleeIns();
			
			
		}

	}
	


	[Command]
	void CmdPlayer1_meleeIns()
	{
		GameObject tmp1 = Instantiate(Player1_meleeIns,player1SpawnPos,Quaternion.identity) as GameObject;
		NetworkServer.SpawnWithClientAuthority(tmp1, connectionToClient);

	}

	[Command]
	void CmdPlayer2_meleeIns()
	{
		GameObject tmp2 = Instantiate(Player2_meleeIns,player2SpawnPos,Quaternion.identity) as GameObject;
		NetworkServer.SpawnWithClientAuthority(tmp2, connectionToClient);
	}



}