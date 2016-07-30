using UnityEngine;
using System.Collections;

public class Pestle : MonoBehaviour {

	private Vector3 _lastMousePosition;

	// Use this for initialization
	void Start () 
	{
		_lastMousePosition = Vector3.zero;
	}
	
	// Update is called once per frame
	void Update () 
	{
		// 操作部分
		Vector3 deltaPosition = Vector3.zero;

//		if(Input.touchCount > 0)
//		{
//			// タッチがあった場合はそちらを優先(スマホ)
//
//			Touch touch = Input.GetTouch(0);
//			Debug.Log(touch.position.y);
//
//			deltaPosition = touch.deltaPosition;
//		}
//		else
//		{
		// タッチがない(PCの可能性)のでマウス操作

		// マウスシミュレーションでタッチも扱う

		//押された瞬間リセット
		if(Input.GetMouseButtonDown(0))
		{
			_lastMousePosition = Input.mousePosition;
		}

		//押されている
		if(Input.GetMouseButton(0))
		{
			deltaPosition = Input.mousePosition - _lastMousePosition;

			float y = deltaPosition.y;
			Debug.Log("y : " + y);
			Vector3 rot = transform.localEulerAngles;
			rot.x += y * 0.1f;

			if(rot.x > 180) rot.x -= 360.0f;

			Debug.Log("rot.x : " + rot.x);

			if(rot.x < -90.0f) rot.x = -90.0f;
			else if(rot.x > 45.0f) rot.x = 45.0f;

			transform.rotation = Quaternion.Euler(rot);

			_lastMousePosition = Input.mousePosition;
		}

		//離したのでリセット
		if(Input.GetMouseButtonUp(0))
		{
			transform.rotation = Quaternion.Euler(new Vector3(0.0f, -45.0f, 0.0f));
		}

//		switch(touch.phase)
//		{
//		case TouchPhase.Began:
//			{
//
//			}
//			break;
//
//		case TouchPhase.Moved:
//			{
//				float y = touch.deltaPosition.y;
//				Vector3 rot = transform.localEulerAngles;
//				rot.x += y * 0.1f;
//				transform.Rotate(new Vector3(rot.x, rot.y, rot.z));
//			}
//			break;
//
//
//		case TouchPhase.Ended:
//		case TouchPhase.Canceled:
//			{
//
//			}
//			break;
//
//		default:
//			break;
//		}
	}
}
