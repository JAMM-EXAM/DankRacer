using UnityEngine;
using System.Collections;

public class Back : MonoBehaviour {

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
		cameraAnim.SetBool ("MainMenu", true);
		cameraAnim.SetBool ("CharSelect", false);
		cameraAnim.SetBool ("Options", false);
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
