using UnityEngine;
using System.Collections;

public class rabbitTop2 : MonoBehaviour {
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
		if (nTime < 50) {
			this.transform.Rotate (0, -0.5f, 0);
		} else if (nTime < 100) {
			this.transform.Rotate (0, 0.5f, 0);
		} else {
			nTime = 0;
		}
		if (nTime == 0) {
			this.transform.rotation = Quaternion.Euler (-102.0f, -90.0f, 90.0f);
		}
	}
}
