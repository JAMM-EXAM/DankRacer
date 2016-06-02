using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class UpdateModel : MonoBehaviour {
    public bool isPlayer = false;
    public Mesh[] meshes;
    public Material[] materials;
    public List<string> models = new List<string>();

    void Start() {
        string model = PlayerPrefs.GetString("PlayerModel");
        if(isPlayer) {
            if(models.Contains(model)) {
                int i = models.IndexOf(model);
                GetComponent<MeshFilter>().mesh = meshes[i];
                GetComponent<Renderer>().material = materials[i];
            }
        } else {
            int i = Random.Range(0, models.Count);
            GetComponent<MeshFilter>().mesh = meshes[i];
            GetComponent<Renderer>().material = materials[i];
        }
    }
}
