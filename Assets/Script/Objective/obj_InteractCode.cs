using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class obj_InteractCode : ObjectiveCode
{
	[Space]
	[Header("Info Variable")]

	public GameObject myObject;

	void Start()
	{
		gameObject.SetActive(false);
	}

	public override void StartObjective()
	{
		myObject.SetActive(true);
	}
	public override void DoingObjective()
	{

	}
	public override void EndObjective()
	{
		gameObject.SetActive(false);
	}

	public void InteractObject(EyeOfPlayerCode playerEye)
	{
		// Debug.Log("Interact broww");
		if (objectiveMaster.int_objIndex == int_myIndex)
		{
			playerEye.fText.SetActive(false);
			objectiveMaster.NextObj();
		}
	}

}
