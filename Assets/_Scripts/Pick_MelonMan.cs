using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Pick_MelonMan : MonoBehaviour {

	GameObject charMesh;
	public ParticleSystem particleSmoke;

	public Mesh MelonMan;
    public Material MelonMaterial;

	// Use this for initialization
	void Start () {
		charMesh = GameObject.Find ("MeshTest");
	}

	void OnMouseUp () 
	{
        PlayerPrefs.SetString("PlayerModel", "Melon");
        SceneManager.LoadScene("game");
    }

	void OnMouseOver ()
	{
		particleSmoke.Emit(100);
        charMesh.GetComponent<MeshFilter> ().mesh = MelonMan;
        charMesh.GetComponent<Renderer> ().material = MelonMaterial;
    }

	void OnMouseExit ()
	{
		particleSmoke.Stop ();
	}
}
