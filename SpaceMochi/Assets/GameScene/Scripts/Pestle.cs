using UnityEngine;
using System.Collections;

public class Pestle : MonoBehaviour {

	public enum PettanState {
		None = -1,

		Pet,	//ぺっ
		Tan,	//たん
	}

	private Vector3 _lastMousePosition;
	private PettanState _pettanState = PettanState.None;

	// Use this for initialization
	void Start () 
	{
		_lastMousePosition = Vector3.zero;
		_pettanState = PettanState.None;
	}
	
	// Update is called once per frame
	void Update () 
	{
		// 操作部分
		Vector3 deltaPosition = Vector3.zero;

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
//			Debug.Log("y : " + y);
			Vector3 rot = transform.localEulerAngles;
			rot.x += y * -0.3f;

			if(rot.x > 180) rot.x -= 360.0f;

//			Debug.Log("rot.x : " + rot.x);

			if(rot.x < -90.0f)
			{
				rot.x = -90.0f;

				if(_pettanState != PettanState.Pet)
				{
					Debug.Log("ぺっ");
					_pettanState = PettanState.Pet;
					GameManager.getInstance.setSystemText("ぺっ");

				}
			}
			else if(rot.x > 45.0f)
			{
				rot.x = 45.0f;
				if(_pettanState != PettanState.Tan)
				{
					Debug.Log("たん");
					_pettanState = PettanState.Tan;
					GameManager.getInstance.setSystemText("たん");
				}
			}
			transform.rotation = Quaternion.Euler(rot);

			_lastMousePosition = Input.mousePosition;
		}

		//離したのでリセット
		if(Input.GetMouseButtonUp(0))
		{
			transform.rotation = Quaternion.Euler(new Vector3(0.0f, -45.0f, 0.0f));
		}
	}
}
