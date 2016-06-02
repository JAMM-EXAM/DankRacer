using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Pick_AssRacer : MonoBehaviour {

	GameObject charMesh;
	public ParticleSystem particleSmoke;

	public Mesh AssRacer;
    public Material AssMaterial;

	// Use this for initialization
	void Start () {
		charMesh = GameObject.Find ("MeshTest");

	}

	void OnMouseUp () 
	{
        PlayerPrefs.SetString("PlayerModel", "Ass Racer");
        SceneManager.LoadScene("game");
    }

	void OnMouseOver ()
	{
		particleSmoke.Emit(100);
        charMesh.GetComponent<Renderer> ().material = AssMaterial;
        charMesh.GetComponent<MeshFilter> ().mesh = AssRacer;
    }
		
	void OnMouseExit ()
	{
		particleSmoke.Stop ();
	}
}
