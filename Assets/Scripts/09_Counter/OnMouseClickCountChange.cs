using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMouseClickCountChange : MonoBehaviour
{
	//-------------------------------------
	public CounterType kind = CounterType.Keys; //［カウンターの種類］
	public int addValue = 1; //［増加量］
	//-------------------------------------
	void Update() 
	{
		if (Input.GetMouseButtonDown(0)) 
		{
    		GameCounter.counters[kind] = GameCounter.counters[kind] + addValue;
        }
    }
}
