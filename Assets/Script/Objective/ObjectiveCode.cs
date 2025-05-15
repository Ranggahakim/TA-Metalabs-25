using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class ObjectiveCode : MonoBehaviour
{
	public ObjectiveMaster objectiveMaster;
	public int int_myIndex;

	[Header("Text on Left Top")]

	public Text objNameTxt;
	public string str_objName;

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
		if (str_objName != "")
		{
			objNameTxt.text = "- " + str_objName;
		}
		else
		{
			objNameTxt.text = "";
		}
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
