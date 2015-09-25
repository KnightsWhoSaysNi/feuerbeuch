using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class Player_SyncPosition : NetworkBehaviour {
	[SyncVar]
	private Vector2 syncPos;
	
	[SerializeField] private Transform myTransform;
	[SerializeField] private float lerpRate = 15;
	
	private Vector2 lastPos;
	private float threshold = 0.5f;
	
	
	// Update is called once per frame
	void FixedUpdate ()
	{
		TransmitPosition();
		LerpPosition();
	}
	
	void LerpPosition()
	{
		if(!isLocalPlayer)
		{
			myTransform.position = Vector2.Lerp(myTransform.position, syncPos, Time.deltaTime * lerpRate);
		}
	}
	
	[Command]
	void CmdProvidePositionToServer(Vector2 pos)
	{
		syncPos = pos;
		Debug.Log("Command called");
	}
	
	[ClientCallback]
	void TransmitPosition()
	{
		if(hasAuthority && Vector2.Distance(myTransform.position, lastPos) > threshold)
		{
			CmdProvidePositionToServer(myTransform.position);
			lastPos = myTransform.position;
		}
		
	}
}