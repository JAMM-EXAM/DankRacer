using UnityEngine;
using System.Collections;

public class RotateY : MonoBehaviour {

    public int rottaFart;
	
	void Update() {
        transform.Rotate(Vector3.up,rottaFart * Time.deltaTime);
    }
}

