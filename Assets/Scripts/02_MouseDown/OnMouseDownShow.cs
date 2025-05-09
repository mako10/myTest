using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// タッチすると、表示する
public class OnMouseDown_Show : MonoBehaviour 
{
	//-------------------------------------
	public GameObject showObject; //［表示するオブジェクト］
	//-------------------------------------

	void Start()
	{
    	showObject.SetActive(false); // 非表示にする
	}

	void OnMouseDown()  // タッチしたら
	{
		showObject.SetActive(true); // 表示する
	}
}
