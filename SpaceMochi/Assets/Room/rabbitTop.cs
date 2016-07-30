using UnityEngine;
using System.Collections;

public class rabbitTop : MonoBehaviour {
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
		if (nTime < 40) {
			this.transform.Rotate (0.0f, 1.0f, 0);
		} else if (nTime < 80) {
			this.transform.Rotate (0.0f, -1.0f, 0);
		} else {
			nTime = 0;
		}
	}
}
