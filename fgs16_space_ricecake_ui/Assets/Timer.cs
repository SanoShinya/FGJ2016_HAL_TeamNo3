//-------------------------------------------------------------------------------------------------
//時間経過処理(Timer.cs)
//Author:imakura kazuhiro
//-------------------------------------------------------------------------------------------------

//ユージング
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

//Timerクラス//////////////////////////////////////////////////////////////////////////////////////
public class Timer : MonoBehaviour
{
    //変数宣言
    public Text timeGUI;        //時間数値文字列化変数
    private float time = 31.0f; //時間初期値
    

    //初期化処理
    void Start()
    {
        timeGUI.text = time.ToString();         //時間を代入
    }

    //更新処理(毎フレーム)
    void Update()
    {
        //タイム
        time -= 1f * Time.deltaTime;            //1秒(60フレーム)毎にカウントダウン
        timeGUI.text = ((int)time).ToString();  //カウントダウンした結果を文字列化し表示
    }
}
