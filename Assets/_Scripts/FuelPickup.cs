using UnityEngine;
using System.Collections;

public class FuelPickup : MonoBehaviour
{
	MeshRenderer meshRenderer;

	public float value;

	bool active;
	float timer;
	public float spawnDelay;

	void Start ()
	{
		meshRenderer = GetComponent<MeshRenderer> ();
		active = true;
	}

	void Update ()
	{
		//hides and disables the pickup for a set amount of time (Spawn Delay)
		if (!active)
		{
            
			timer += Time.deltaTime;

			if (timer >= spawnDelay)
			{
				
				timer = 0;
               
				meshRenderer.enabled = true;
				active = true;
			}
		}
	}

	void OnTriggerEnter (Collider other)
	{
		//only give boostfuel if this fuel pickup is active
		if (active && other.transform.tag == "Player")
		{
			other.GetComponent<PlayerController> ().boostFuel += value;

			if (other.GetComponent<PlayerController> ().boostFuel == other.GetComponent<PlayerController> ().maxBoostFuel)
				other.GetComponent<PlayerController> ().boostFuel = other.GetComponent<PlayerController> ().maxBoostFuel;

			meshRenderer.enabled = false;
			active = false;
		}
	}
}
