using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameManager : SingletonMonoBehaviour<GameManager> {

	// ゲームの進行ステータス
	private enum State {
		None = -1, 

		StartCountDown = 0,
		Play,
		Pause,
		Goal,

		Finish,
	}

	// パラメータ
	private State _state = State.None;
	private float _startCountDownTimer = 0.0f;
	private Pestle _pestle = null;
	private Canvas _uiCanvas = null;
	private Text _startCountDownText = null;
	private Timer _timerUI = null;
	private Distance _distanceUI = null;

	private string[] str = new string[]{ "hoge", "hoge", "hoge" }; 

	// Use this for initialization
	void Start () {
		_state = State.StartCountDown;
		_startCountDownTimer = 3.0f;

		// 杵　最初は動かないのでenebleをfalseする
		_pestle = GameObject.Find("Pestle").GetComponent<Pestle>(); 
		_pestle.enabled = false;

		// UIキャンバス
		_uiCanvas = GameObject.Find("DummyUI").GetComponent<Canvas>();

		// タイマー
		_timerUI = GameObject.Find("UI/Canvas/time_number").GetComponent<Timer>();
		_timerUI.enabled = false;

		// 距離メーター
		_distanceUI = GameObject.Find("UI/Canvas/distance_number").GetComponent<Distance>();
		_distanceUI.enabled = false;

		// ゲーム開始カウントダウン
		Text target = null;
		foreach (Transform child in _uiCanvas.transform){
			if(child.name == "Text"){
				target = child.gameObject.GetComponent<Text>();
				target.text = "3";
			}
		}

		if(target != null) _startCountDownText = target;

		// BGM再生
		AudioManager.getInstance.PlayBGM("game");
	}
	
	// Update is called once per frame
	void Update () {

		switch(_state)
		{
		case State.StartCountDown:
			{
				_startCountDownTimer -= Time.deltaTime;
//				Debug.Log(Time.deltaTime);

				if(string.Compare("3", _startCountDownText.text) == 0 && _startCountDownTimer <= 2.0f)
				{
					_startCountDownText.text = "2";
				}
				else if(string.Compare("2", _startCountDownText.text) == 0 && _startCountDownTimer <= 1.0f)
				{
					_startCountDownText.text = "1";
				}
				else if(string.Compare("1", _startCountDownText.text) == 0 && _startCountDownTimer <= 0.0f)
				{
					_startCountDownText.text = "";
					_state = State.Play;
					_pestle.enabled = true; //杵を有効
					_timerUI.enabled = true;  //タイマーを有効化
					_distanceUI.enabled = true; //距離メーターを有効化
				}
			}
			break;

		case State.Play:
			{
				if(_distanceUI.getDistance() <= 0.0f)
				{
					//終了
					Application.LoadLevel("xxResultxx");
					_state = State.Goal;
				}
			}
			break;

		default:
			break;	
		}

	}

	public void setSystemText(string text)
	{
		_startCountDownText.text = text;


	}

	public void callPet(){ _distanceUI.addSpeed(50.0f); }
	public void callTan(){ _distanceUI.addSpeed(50.0f); }
}
