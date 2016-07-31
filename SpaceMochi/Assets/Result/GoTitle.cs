using UnityEngine;
using System.Collections;

public class GoTitle : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void clickGoTitle()
    {
        Application.LoadLevel("Title");
        print("OK");
    }

}
