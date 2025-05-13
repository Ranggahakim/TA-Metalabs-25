using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveMaster : MonoBehaviour
{

	public ObjectiveCode[] objectives;

	public int int_objIndex;
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
			obj.int_myIndex = index;
			index++;
		}

		objectives[0].StartObjective();
	}

	// Update is called once per frame
	void Update()
	{

	}

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
