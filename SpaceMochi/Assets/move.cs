using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {

    float kaiten = 0.0f;

	// Use this for initialization
	void Start () {
       // kaiten = 0.1f;

        iTween.RotateBy(gameObject, iTween.Hash("y", 30,
            "time", 1800, 
            "looptype", iTween.LoopType.loop,
            "easetype", iTween.EaseType.linear));
	}
	
	// Update is called once per frame
	void Update () {

//        transform.rotation = new Quaternion(kaiten + 0.1f , kaiten , kaiten , kaiten);
//        kaiten++;
	}
}
