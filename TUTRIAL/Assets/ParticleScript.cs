using UnityEngine;
using System.Collections;

public class ParticleScript : MonoBehaviour
{
    static float time = 0;

	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        //エフェクトの設定
        SetEffect(1.0f, 1.0f, 0.0f, 3.0f, 10.0f);

        // エフェクトの再生
        if (Input.GetKey("a"))
        {
            GetComponent<ParticleSystem>().Play();
            time = 0;   //タイマーのリセット
        }

        //タイマーが規定値を超えたら
        if (time > 0.5f)
        {
            // エフェクトの停止
            GetComponent<ParticleSystem>().Stop();
        }
        //タイマーのカウント
        else
        {
            time += Time.deltaTime;
        }
	}

    //エフェクトの設定(RGB値, サイズ)
    void SetEffect(float red, float green, float blue, float size, float life)
    {
        // カラーの設定
        Color color = new Color(red, green, blue, 1.0f);

        ParticleSystem ps = GetComponent<ParticleSystem>();
        var col = ps.colorOverLifetime;
        col.enabled = true;
        
        Gradient grad = new Gradient();
        //grad.SetKeys(new GradientColorKey[] { new GradientColorKey(Color.red, red), new GradientColorKey(Color.green, green), new GradientColorKey(Color.blue, blue) }, new GradientAlphaKey[] { new GradientAlphaKey(1.0f, 0.0f), new GradientAlphaKey(0.0f, 1.0f) });
        grad.SetKeys(new GradientColorKey[] { new GradientColorKey(color, 1.0f) }, new GradientAlphaKey[] { new GradientAlphaKey(1.0f, 0.0f), new GradientAlphaKey(0.0f, 1.0f) });
        
        col.color = new ParticleSystem.MinMaxGradient(grad);

        //サイズの設定
        ps.startSize = size;

        //エフェクトの表示時間の設定
        ps.startLifetime = life;
    }
}