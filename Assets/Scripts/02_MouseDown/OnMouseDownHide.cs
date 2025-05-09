using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// タッチすると、消す
public class OnMouseDownHide : MonoBehaviour 
{
	void OnMouseDown()  // タッチしたら
	{
		gameObject.SetActive(false); // 消す
	}
}
