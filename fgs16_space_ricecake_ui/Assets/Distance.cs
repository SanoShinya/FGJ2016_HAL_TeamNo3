//-------------------------------------------------------------------------------------------------
//距離計測処理(Distance.cs)
//Author:imakura kazuhiro
//-------------------------------------------------------------------------------------------------

//ユージング
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

//Distanceクラス///////////////////////////////////////////////////////////////////////////////////
public class Distance : MonoBehaviour
{
    public Text distanceGUI = null;             //距離の文字列化

    private float distance = 384400.0f;  //距離の初期値を設定
    private float speed  = 1397.0f;      //スペースシャトル航行速度(※※※暫定的に固定値)
    private int digit = 0;               //桁数を検出

    //初期化処理
    void Start ()
    {
        distanceGUI.text = distance.ToString(); //距離を代入
    }
	
	//更新処理(毎フレーム)
	void Update (/*航行速度speed*/)
    {
        if (distanceGUI == null)
        {
            Debug.Log("null");
        }


        distance -= speed;                           //速度-距離
        if(distance < 0)                             //距離カンスト
        {
            distance = 0;                            //ゼロへ
        }
        digit = 6 - distance.ToString().Length;      //現在の余り桁数を検出
        if (digit == 6)
        {
            distanceGUI.text = " ";                  //文字列をクリア
            distanceGUI.text = distance.ToString();  //6桁の距離を代入
        }
        else
        {
            distanceGUI.text = " ";                  //※※※NULL EXPECTION ERROR???
            for (int i = 0; i < digit; i++)          //余り桁数分ゼロを文字列に格納
            {
                distanceGUI.text += "0";             //ゼロを文字列に格納
            }
            distanceGUI.text += distance.ToString(); //距離を文字列に格納して表示
        }
	}
}
