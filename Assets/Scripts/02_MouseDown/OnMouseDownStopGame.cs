using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// タッチすると、ゲームをストップする
public class OnMouseDownStopGame : MonoBehaviour 
{
	void Start ()
	{
		Time.timeScale = 1; // 時間を動かす
	}

	void OnMouseDown()  // タッチしたら
	{
		Time.timeScale = 0; // 時間を止める
	}
}
