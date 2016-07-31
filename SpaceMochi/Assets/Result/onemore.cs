using UnityEngine;
using System.Collections;

public class onemore : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void clickGoGame()
    {
        Application.LoadLevel("GameScene");
        print("OK");
    }
}
