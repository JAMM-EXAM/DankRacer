using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Pick_Vapinator : MonoBehaviour {

	GameObject charMesh;
	public ParticleSystem particleSmoke;

	public Mesh Vapinator;
    public Material VapinatorMaterial;

	// Use this for initialization
	void Start () {
		charMesh = GameObject.Find ("MeshTest");

	}

	void OnMouseUp () 
	{
        PlayerPrefs.SetString("PlayerModel", "Vapinator");
        SceneManager.LoadScene("game");
    }

	void OnMouseOver ()
	{
		particleSmoke.Emit(100);
        charMesh.GetComponent<MeshFilter> ().mesh = Vapinator;
        charMesh.GetComponent<Renderer> ().material = VapinatorMaterial;
    }

	void OnMouseExit ()
	{
		particleSmoke.Stop ();
	}
}
