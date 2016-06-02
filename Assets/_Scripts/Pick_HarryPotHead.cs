using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Pick_HarryPotHead : MonoBehaviour {

	GameObject charMesh;
	public ParticleSystem particleSmoke;

	public Mesh HarryPotHead;
    public Material PotMaterial;

	// Use this for initialization
	void Start () {
		charMesh = GameObject.Find ("MeshTest");

	}

	void OnMouseUp () 
	{
        PlayerPrefs.SetString("PlayerModel", "Harry Pothead");
        SceneManager.LoadScene("game");
    }

	void OnMouseOver ()
	{
		particleSmoke.Emit(100);
        charMesh.GetComponent<Renderer> ().material = PotMaterial;
        charMesh.GetComponent<MeshFilter> ().mesh = HarryPotHead;
    }

	void OnMouseExit ()
	{
		particleSmoke.Stop ();
	}
}
