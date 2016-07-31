using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SceneKanri : MonoBehaviour {

    bool tekitou;
    bool Result;
    int Cnt;

    private GameObject UI1;
    private GameObject UI2;

    // Use this for initialization
    void Start () {

        tekitou = false;
        Result = false;
        Cnt = 0;

        UI1 = GameObject.Find("Canvas2");
        UI2 = GameObject.Find("Canvas");
        UI2.GetComponent<Canvas>().enabled = false;

        // BGM再生
        AudioManager.getInstance.PlayBGM("i76005_in_secret");
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
            UI1.GetComponent<Canvas>().enabled = false;
            UI2.GetComponent<Canvas>().enabled = true;

        }



    }
}
