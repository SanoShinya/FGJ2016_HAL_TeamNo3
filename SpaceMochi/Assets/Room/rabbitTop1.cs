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
		if (nTime < 50) {
			this.transform.Rotate (0.0f, 1.5f, 0);
		} else if (nTime < 100) {
			this.transform.Rotate (0.0f, -1.5f, 0);
		} else {
			nTime = 0;
		}
	}
}
