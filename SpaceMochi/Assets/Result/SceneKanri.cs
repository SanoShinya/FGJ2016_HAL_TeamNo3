using UnityEngine;
using System.Collections;

public class SceneKanri : MonoBehaviour {

    bool tekitou;
    bool Result;
    int Cnt;

	// Use this for initialization
	void Start () {

        tekitou = false;
        Result = false;
        Cnt = 0;
	}
	
	// Update is called once per frame
	void Update () {


        if (Result == false)
        {
          if (Input.GetMouseButtonDown(0)) {
              print("いま左ボタンが押された");
              tekitou = true;
            }
        }

        if (tekitou == true )
        {
            if (Result == false)
            {
                transform.position += new Vector3(0.1f, 0f, 0f);
                Cnt++;
            }
        }

        if (Cnt == 70)
        {
            Result = true;
            GetComponent<Canvas>().enabled = false;
        }


	
	}
}
