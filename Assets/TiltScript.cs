﻿using UnityEngine;
using System.Collections;

public class TiltScript : MonoBehaviour
{
	Vector3 standardRtoation;
	Vector3 leftTilt;
	Vector3 rightTilt;

	void Start ()
	{
		standardRtoation = transform.localEulerAngles;
		leftTilt = new Vector3 (0, 0, 25);
		rightTilt = new Vector3 (0, 0, -25);
	}

	void Update ()
	{
		if (Input.GetKey (KeyCode.A))
			transform.localEulerAngles = leftTilt;
		if (Input.GetKey (KeyCode.D))
			transform.localEulerAngles = rightTilt;
	}
}