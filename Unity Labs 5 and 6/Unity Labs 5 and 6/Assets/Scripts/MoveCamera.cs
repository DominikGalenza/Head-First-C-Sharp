using System;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    [SerializeField] private Transform player;
	[SerializeField] private float angle = 3f;
	[SerializeField] private float zoomSpeed = 0.25f;

	private void Update()
	{
		RotateTheCamera();
		ZoomTheCamera();
		LookAtThePlayer();
	}

	private void RotateTheCamera()
	{
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			transform.RotateAround(player.position, Vector3.down, angle);
		}
		if (Input.GetKey(KeyCode.RightArrow))
		{
			transform.RotateAround(player.position, Vector3.up, angle);
		}
		if (Input.GetKey(KeyCode.UpArrow))
		{
			transform.RotateAround(player.position, Vector3.right, angle);
		}
		if (Input.GetKey(KeyCode.DownArrow))
		{
			transform.RotateAround(player.position, Vector3.left, angle);
		}
	}

	private void ZoomTheCamera()
	{
		float scrollWheelValue = Input.GetAxis("Mouse ScrollWheel");
		if (scrollWheelValue != 0)
		{
			transform.position *= 1f + scrollWheelValue * zoomSpeed;
		}
	}

	private void LookAtThePlayer()
	{
		transform.LookAt(player.position);
	}
}
