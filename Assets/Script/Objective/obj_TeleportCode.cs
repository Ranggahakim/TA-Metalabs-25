using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class obj_TeleportCode : ObjectiveCode
{
	[Space]
	[Header("Info Variable")]

	public Transform targetLocation;
	public GameObject myPlayer;

	void Start()
	{
		myPlayer = GameObject.FindWithTag("Player");
	}

	public override void StartObjective()
	{
		myPlayer.transform.position = targetLocation.position;

		objectiveMaster.NextObj();
	}
	public override void DoingObjective()
	{

	}
	public override void EndObjective()
	{

	}
}
