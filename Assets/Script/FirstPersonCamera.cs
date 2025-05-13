using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{
	public float sensitivity = 100f;

	public Transform body;

	float XRotation;

	// Start is called before the first frame update
	void Start()
	{
		sensitivity = PlayerPrefs.GetFloat("currentSensitivity", 100);

		Cursor.visible = false;

		Cursor.lockState = CursorLockMode.Locked;
	}

	// Update is called once per frame
	void Update()
	{
		float MouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
		float MouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

		XRotation -= MouseY;
		XRotation = Mathf.Clamp(XRotation, -90, 90);

		transform.localRotation = Quaternion.Euler(XRotation, 0, 0);
		body.Rotate(Vector3.up * MouseX);
	}
}