using UnityEngine;
using System.Collections;

public class rabbitTop1 : MonoBehaviour {
	int nTime;
	void Start()
	{
		nTime = 0;
	}

	/// <summary>
	/// 表示アニメーション
	/// </summary>
	void Update(){
		nTime++;
		if (nTime < 20) {
			this.transform.Rotate (0, 3.0f, 0);
		} else if (nTime < 40) {
			this.transform.Rotate (0, -3.0f, 0);
		} else {
			nTime = 0;
		}
		if (nTime == 0) {
			this.transform.rotation = Quaternion.Euler (-55.0f, -90.0f, 90.0f);
		}
	}
}
