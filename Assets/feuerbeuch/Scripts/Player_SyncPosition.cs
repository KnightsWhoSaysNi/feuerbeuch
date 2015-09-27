﻿using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class Player_SyncPosition : NetworkBehaviour {
	[SyncVar]
	private Vector3 syncPos;
	
	[SerializeField] private Transform myTransform;
	[SerializeField] private float lerpRate = 15;
	
	private Vector3 lastPos;
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
			myTransform.position = Vector3.Lerp(myTransform.position, syncPos, Time.deltaTime * lerpRate);
		}
	}
	
	[Command]
	void CmdProvidePositionToServer(Vector3 pos)
	{
		syncPos = pos;
		Debug.Log("Command called");
	}
	
	[ClientCallback]
	void TransmitPosition()
	{
		if(hasAuthority && Vector3.Distance(myTransform.position, lastPos) > threshold)
		{
			CmdProvidePositionToServer(myTransform.position);
			lastPos = myTransform.position;
		}
		
	}
}