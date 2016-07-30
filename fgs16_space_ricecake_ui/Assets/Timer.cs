//-----------------------------------------------------------------------------
//時間経過処理(Timer.cs)

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour
{
    public Text timeGUI;

    private float time = 31.0f;
    

    //初期化処理
    void Start()
    {
        timeGUI.text = time.ToString();
    }

    //更新処理(毎フレーム)
    void Update()
    {
        //タイム
        time -= 1f * Time.deltaTime;
        timeGUI.text = ((int)time).ToString();
    }
}
