//-------------------------------------------------------------------------------------------------
//色変更処理()
//Author:imakura kazuhiro
//-------------------------------------------------------------------------------------------------

using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class SpeedMeter : MonoBehaviour
{

    RectTransform rt;

    private float height = 600;
    //初期化処理
    void Start ()
    {
        rt = GetComponent<RectTransform>();
    }

    //更新処理(毎フレーム)
    void Update()
    {
        height -= 1;
        rt.sizeDelta = new Vector2(70, height);
    }
}
