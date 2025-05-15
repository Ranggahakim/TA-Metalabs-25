using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostSpriteCode : MonoBehaviour
{
	public bool inPlayerArea = true;

	public float minRnd = 3f;
	public float maxRnd = 6f;

	[Space]
	public GameObject[] ghostImages;
	public GameObject cameraTarget;
	// Use this for initialization
	void Start()
	{
		inPlayerArea = true;
		cameraTarget = GameObject.FindWithTag("MainCamera");
	}

	// Update is called once per frame
	void Update()
	{
		Vector3 directionToPlayer;

		directionToPlayer = transform.position - cameraTarget.transform.position;
		transform.rotation = Quaternion.LookRotation(directionToPlayer);
	}

	IEnumerator ShowSprite()
	{
		float rnd = Random.Range(minRnd, maxRnd);
		yield return new WaitForSeconds(rnd);

		if (!inPlayerArea)
		{
			int rndImage = Random.Range(0, ghostImages.Length - 1);
			ghostImages[rndImage].SetActive(true);

			float rnd2 = Random.Range(.5f, 3f);
			yield return new WaitForSeconds(rnd2);

			ghostImages[rndImage].SetActive(false);

			StartCoroutine(ShowSprite());
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			inPlayerArea = true;
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			inPlayerArea = false;
			StartCoroutine(ShowSprite());
		}

	}
}
