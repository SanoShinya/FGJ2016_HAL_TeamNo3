using UnityEngine;
using System.Collections;

public class rabbitTop3 : MonoBehaviour {
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
		if (nTime < 100) {
		}
		else if (nTime < 140) {
			this.transform.position += new Vector3 (0, -0.01f, 0);
		} else if (nTime < 144) {
			this.transform.position += new Vector3 (0, 0.1f, 0);
		} else {
			nTime = 0;
		}
	}
}
