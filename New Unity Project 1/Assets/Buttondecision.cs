using UnityEngine;
using System.Collections;

public class Buttondecision : MonoBehaviour
{

	// Use this for initialization
	void Start ( )
    {
	
	}
	
	// Update is called once per frame
	void Update ( )
    {
        /*        if(  )
                {
        
                }*/
        if ( Input.GetMouseButtonDown( 0 ) )
        {
            print("左ボタンが押された");
        }
	}
}
