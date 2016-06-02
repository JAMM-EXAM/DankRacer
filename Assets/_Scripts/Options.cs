using UnityEngine;
using System.Collections;

public class Options : MonoBehaviour {
	
	public ParticleSystem particleSmoke;
	public Animator cameraAnim;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown () 
	{	 
		cameraAnim.SetBool ("Options", true);
		cameraAnim.SetBool ("MainMenu", false);
	}

	void OnMouseOver ()
	{
		particleSmoke.Emit (100);
	}

	void OnMouseExit ()
	{
		particleSmoke.Stop ();
	}
}
