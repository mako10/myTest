using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// タッチすると、カウントを変更する
public class OnMouseDownCountChange : MonoBehaviour 
{
	//-------------------------------------
	public CounterType kind = CounterType.Keys; //［カウンターの種類］
	public int addValue = 1; //［増加量］
	//-------------------------------------

	void OnMouseDown() // タッチしたら
	{
		// カウンターの値を変更する
		GameCounter.counters[kind] = GameCounter.counters[kind] + addValue;
	}
}
