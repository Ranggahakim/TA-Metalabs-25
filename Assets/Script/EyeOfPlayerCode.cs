using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeOfPlayerCode : MonoBehaviour
{

	public Transform cam;
	public float maxDistance = 10;

	public GameObject viewedObject;

	public GameObject fText;

	// Use this for initialization
	void Start()
	{

	}

	void FixedUpdate()
	{
		RaycastHit hit;
		Ray ray = new Ray(cam.position, cam.forward);

		Debug.DrawLine(ray.origin, ray.direction, Color.green);
		if (Physics.Raycast(ray, out hit, maxDistance))
		{
			viewedObject = hit.collider.gameObject;
			if (viewedObject.GetComponent<obj_InteractCode>() && viewedObject.GetComponent<obj_InteractCode>().objectiveMaster.int_objIndex == viewedObject.GetComponent<obj_InteractCode>().int_myIndex)
			{
				fText.SetActive(true);
			}
			else if (viewedObject.GetComponent<obj_LookAtCode>())
			{
				viewedObject.GetComponent<obj_LookAtCode>().LookAtObject();
			}

			if (viewedObject.GetComponent<SearchedObjectCode>())
			{
				fText.SetActive(true);
			}
		}
		else
		{
			fText.SetActive(false);
		}
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.F))
		{
			if (viewedObject != null)
			{
				if (viewedObject.GetComponent<obj_InteractCode>())
				{
					viewedObject.GetComponent<obj_InteractCode>().InteractObject(this);
				}
				if (viewedObject.GetComponent<SearchedObjectCode>())
				{
					viewedObject.GetComponent<SearchedObjectCode>().InteractObject(this);
				}

				Debug.Log(viewedObject.gameObject.name);
			}
		}
	}
}
