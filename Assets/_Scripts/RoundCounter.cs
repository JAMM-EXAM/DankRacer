using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class RoundCounter : MonoBehaviour {
    public int roundsToWin = 3;
    public int currentPlayerLaps = 0;

    public Text UI;
    public Texture winImage;
    public RawImage winBackground;
    public GameObject winLoseScreen;

    public List<EnemyAI> ai = new List<EnemyAI>();
    public List<int> aiLaps = new List<int>();

    void Awake() {
        winLoseScreen.SetActive(false);
    }

    void OnTriggerEnter(Collider coll) {
        if(coll.CompareTag("Player")) {
            currentPlayerLaps++;
            UI.text = currentPlayerLaps + " / " + roundsToWin;
            if(currentPlayerLaps >= roundsToWin) {
                Debug.Log("YOU WIN!");
                GameObject.Find("Player").GetComponent<PlayerController>().run = false;
                winBackground.texture = winImage;
                winLoseScreen.SetActive(true);
            }
        } else {
            try {
                EnemyAI eAI = coll.GetComponent<EnemyAI>();
                int i = ai.IndexOf(eAI);
                aiLaps[i] = aiLaps[i] + 1;
                if(aiLaps[i] >= roundsToWin) {
                    Debug.Log(eAI.gameObject.name + " wins!");
                    GameObject.Find("Player").GetComponent<PlayerController>().run = false;
                    winLoseScreen.SetActive(true);
                    eAI.run = false;
                }
            } catch { }
        }
    }
}
