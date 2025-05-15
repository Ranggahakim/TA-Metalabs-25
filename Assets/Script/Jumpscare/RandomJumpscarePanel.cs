using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomJumpscarePanel : MonoBehaviour
{
	[SerializeField] GameObject jumpscarePanel;

	[SerializeField] float minRnd = 15f;
	[SerializeField] float maxRnd = 30f;

	// Use this for initialization
	void Start()
	{
		jumpscarePanel.SetActive(false);
		// gameObject.SetActive(false);
	}

	// Update is called once per frame
	void Update()
	{

	}

	void OnEnable()
	{
		Debug.Log("Enable");
		StartCoroutine(ShowJumpscare());
	}

	IEnumerator ShowJumpscare()
	{
		float rnd = Random.Range(minRnd, maxRnd);
		yield return new WaitForSeconds(rnd);
		jumpscarePanel.SetActive(true);

		float rnd2 = Random.Range(.5f, 3f);
		yield return new WaitForSeconds(rnd2);
		jumpscarePanel.SetActive(false);

		StartCoroutine(ShowJumpscare());

	}
}
