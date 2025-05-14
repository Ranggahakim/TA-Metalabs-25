using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchedObjectCode : MonoBehaviour
{
	public obj_FindObjects myObjective;
	public GameObject theObject;
	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}

	public void InteractObject(EyeOfPlayerCode playerEye)
	{
		playerEye.fText.SetActive(false);

		myObjective.FindObject(this);
		theObject.SetActive(false);

		gameObject.SetActive(false);
	}
}
