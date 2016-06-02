using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour {

	public Animator cameraAnim;
	public ParticleSystem particleSmoke;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown () 
	{	 
		cameraAnim.SetBool ("CharSelect", true);
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
