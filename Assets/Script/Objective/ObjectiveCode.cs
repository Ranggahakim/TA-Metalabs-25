using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ObjectiveCode : MonoBehaviour
{
	public ObjectiveMaster objectiveMaster;
	public int int_myIndex;

	[Header("Text on Left Top")]


	public string str_objName;
	public string str_objDesc;

	[Space]
	[Header("GameObject to Active or NonActive")]

	[Header("On Start")]
	public GameObject[] activeOnStartGameObject;
	public GameObject[] nonActiveOnStartGameObject;

	[Header("On End")]
	public GameObject[] activeOnEndGameObject;
	public GameObject[] nonActiveOnEndGameObject;

	public void SetGameObjectActiveOnStart()
	{
		foreach (GameObject obj in nonActiveOnStartGameObject)
		{
			obj.SetActive(false);
		}
	}

	public void SetGameObjectNonActiveOnStart()
	{
		foreach (GameObject obj in activeOnStartGameObject)
		{
			obj.SetActive(true);
		}
	}

	public void SetGameObjectActiveOnEnd()
	{
		foreach (GameObject obj in nonActiveOnEndGameObject)
		{
			obj.SetActive(false);
		}
	}

	public void SetGameObjectNonActiveOnEnd()
	{
		foreach (GameObject obj in activeOnEndGameObject)
		{
			obj.SetActive(true);
		}
	}

	public void DefaultStart()
	{
		SetGameObjectActiveOnStart();
		SetGameObjectNonActiveOnStart();
	}

	public void DefaultEnd()
	{
		SetGameObjectActiveOnEnd();
		SetGameObjectNonActiveOnEnd();
	}

	public abstract void StartObjective();

	public abstract void DoingObjective();

	public abstract void EndObjective();
}
