using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class obj_LookAtCode : ObjectiveCode
{
	// [Space]
	// [Header("Info Variable")]


	public override void StartObjective()
	{
	}
	public override void DoingObjective()
	{

	}
	public override void EndObjective()
	{

	}

	public void LookAtObject()
	{
		// Debug.Log("Interact broww");
		if (objectiveMaster.int_objIndex == int_myIndex)
		{
			objectiveMaster.NextObj();
		}
	}

}
