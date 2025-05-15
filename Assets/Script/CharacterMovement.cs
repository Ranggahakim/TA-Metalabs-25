using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
	public CharacterController myController;

	public bool isDisabled = false;

	public float speed = 4;
	public float gravity = -9.8f;

	public Transform groundCheck;
	public float groundDistance = 0.4f;
	public LayerMask groundMask;

	Vector3 velocity;
	bool isGrounded;

	[SerializeField] Animator myAnim;
	void Update()
	{
		if (!isDisabled)
		{
			isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

			if (isGrounded && velocity.y < 0)
			{
				velocity.y = -2f;
			}

			float x = Input.GetAxisRaw("Horizontal");
			float z = Input.GetAxisRaw("Vertical");

			if (x != 0 || z != 0)
			{
				myAnim.SetBool("isWalk", true);
			}
			else
				myAnim.SetBool("isWalk", false);

			Vector3 move = transform.right * x + transform.forward * z;

			myController.Move(move * speed * Time.deltaTime);

			velocity.y += gravity * Time.deltaTime;

			myController.Move(velocity * Time.deltaTime);
		}
	}
}
