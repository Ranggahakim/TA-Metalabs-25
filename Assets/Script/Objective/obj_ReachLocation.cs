using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class obj_ReachLocation : ObjectiveCode
{
	[Space]
	[Header("Info Variable")]

	public GameObject theCube;

	void Start()
	{
		theCube.SetActive(false);
	}

	public override void StartObjective()
	{
		theCube.SetActive(true);
	}
	public override void DoingObjective()
	{

	}
	public override void EndObjective()
	{
		theCube.SetActive(false);
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player" && objectiveMaster.int_objIndex == int_myIndex)
		{
			objectiveMaster.NextObj();
			Debug.Log("HOHO");
		}
	}

}
