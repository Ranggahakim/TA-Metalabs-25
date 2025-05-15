using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectiveMaster : MonoBehaviour
{

	public ObjectiveCode[] objectives;

	public int int_objIndex;
	public Text objNameTxt;
	public Text subTxt;
	// Use this for initialization
	void Start()
	{
		defObjective();
	}

	public void defObjective()
	{
		int index = 0;
		foreach (ObjectiveCode obj in objectives)
		{
			obj.objectiveMaster = this;
			obj.objNameTxt = objNameTxt;
			obj.int_myIndex = index;
			index++;
		}

		objectives[0].DefaultStart();
		objectives[0].StartObjective();
	}

	// Update is called once per frame
	void Update()
	{

	}


	[ContextMenu("Next Tutorial")]
	public void NextObj()
	{
		objectives[int_objIndex].DefaultEnd();
		objectives[int_objIndex].EndObjective();

		if (int_objIndex < objectives.Length - 1)
		{
			int_objIndex++;

			objectives[int_objIndex].DefaultStart();
			objectives[int_objIndex].StartObjective();
		}

	}
}
