using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class obj_FindObjects : ObjectiveCode
{
	[Space]
	[Header("Info Variable")]

	public List<SearchedObjectCode> targets;
	public List<SearchedObjectCode> founded;

	void Start()
	{
		foreach (SearchedObjectCode tgt in targets)
		{
			tgt.myObjective = this;
			tgt.gameObject.SetActive(false);
		}
	}

	public override void StartObjective()
	{
		foreach (SearchedObjectCode tgt in targets)
		{
			tgt.gameObject.SetActive(true);
		}
	}
	public override void DoingObjective()
	{

	}
	public override void EndObjective()
	{

	}

	public void FindObject(SearchedObjectCode soc)
	{
		// Debug.Log("Interact broww");
		if (objectiveMaster.int_objIndex == int_myIndex)
		{
			founded.Add(soc);
			if (targets.Count == founded.Count)
			{
				objectiveMaster.NextObj();
			}
		}
	}

}
