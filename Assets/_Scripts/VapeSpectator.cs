using UnityEngine;
using System.Collections;

public class VapeSpectator : MonoBehaviour
{
	public Transform playerTrans;
	Vector3 dirVector;


	void Start ()
	{
		playerTrans = GameObject.Find ("Player").transform;
	}

	void Update ()
	{
		if (playerTrans != null)
		{
			Vector3 vector = playerTrans.position - transform.position;
			vector.y = 0f;

			transform.rotation = Quaternion.LookRotation (-vector);
		}
	}
}
