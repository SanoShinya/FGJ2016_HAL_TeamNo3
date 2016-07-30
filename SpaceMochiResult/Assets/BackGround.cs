using UnityEngine;
using System.Collections;



public class BackGround : MonoBehaviour {


    public bool Timi;
    public int basaCnt;

    //public Vector3 position;

	// Use this for initialization
	void Start () {

        Timi = false;
        basaCnt = 0;
	}
	
	// Update is called once per frame
	void Update () 
    {
        if(Timi == false)
        {
            transform.position -= new Vector3(0.001f, 0f, 0f);
            basaCnt++;
            print("FALSE");
        }
        else if (Timi == true)
        {
            transform.position += new Vector3(0.001f, 0f, 0f);
            basaCnt++;
            print("TRUE");
        }


        if(basaCnt == 3000)
        {
            basaCnt = 0;

            if (Timi == false)
            {
                Timi = true;
            }
            else if (Timi == true)
            {
                Timi = false;
            }
        }


	}
}
