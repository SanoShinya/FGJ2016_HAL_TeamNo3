using UnityEngine;
using System.Collections;

public class BGM : MonoBehaviour {

	// Use this for initialization
	void Start ( ) {
        // BGM再生
        AudioManager.getInstance.PlayBGM("Title_SOUND_03");

	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            // SE再生
            AudioManager.getInstance.PlaySE("Koukaon02");
        }
	
	}
}
