using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class UpdatePlayerModel : MonoBehaviour {
    public Mesh[] meshes;
    public Material[] materials;
    public List<string> models = new List<string>();

	void Start() {
        string model = PlayerPrefs.GetString("PlayerModel");
        if(models.Contains(model)) {
            int i = models.IndexOf(model);
            GetComponent<MeshFilter>().mesh = meshes[i];
            GetComponent<Renderer>().material = materials[i];
        }
    }
}
