using UnityEngine;
using System.Collections;

public class Generator : MonoBehaviour {

    public GameObject obstacle;
    private int score = 0;

	void Start () {
        InvokeRepeating("CreatePipe", 0, 2f);
	}

    void CreatePipe()
    {
        Instantiate(obstacle);
        score++;
    }

    void OnGUI()
    {
        GUI.color = Color.black;
        GUILayout.Label(" Score: " + score.ToString());
    }
}
