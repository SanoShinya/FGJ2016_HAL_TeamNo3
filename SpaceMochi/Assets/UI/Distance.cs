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
    public Text distanceGUI;             //距離の文字列化

    private float distance = 384400.0f;  //距離の初期値を設定
    private float speed  = 0.0f;     //スペースシャトル航行速度(※※※暫定的に固定値)
    private int digit = 0;               //桁数を検出
	private float accel = -1.0f;

	private BackScript _bg;

    //初期化処理
    void Start ()
    {
        distanceGUI.text = distance.ToString(); //距離を代入

		_bg = GameObject.Find("Space/shootingstar").GetComponent<BackScript>();
    }
	
	//更新処理(毎フレーム)
	void Update (/*航行速度speed*/)
    {
        distance -= speed;                           //速度-距離
		speed = Mathf.Max(speed - accel, 0.0f);		//加速度で速度を更新

        if(distance < 0)                             //距離カンスト
        {
            distance = 0;                            //ゼロへ
        }
        digit = 6 - distance.ToString().Length;      //現在の余り桁数を検出
        if (digit == 6)
        {
            distanceGUI.text = "";                   //文字列をクリア
            distanceGUI.text = distance.ToString();  //6桁の距離を代入
        }
        else
        {
            distanceGUI.text = "";                   //※※※NULL EXPECTION ERROR???
            for (int i = 0; i < digit; i++)          //余り桁数分ゼロを文字列に格納
            {
                distanceGUI.text += "0";             //ゼロを文字列に格納
            }
            distanceGUI.text += distance.ToString(); //距離を文字列に格納して表示
        }
	}

	public void setSpeed(float setSpeed)
	{
		speed = setSpeed;
	} 
	public float getSpeed() { return speed; }
	public void addSpeed(float add){ speed += add; }

	public float getDistance(){ return distance; }
}
