﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// タッチすると、そこにプレハブを作る
public class OnMouseDownCreatePrefab : MonoBehaviour 
{
	//-------------------------------------
	public GameObject newPrefab; //［作るプレハブ］
    public int newZ = -5; //［描画順］
	//-------------------------------------

	void Update() 
	{
		if (Input.GetMouseButtonDown(0)) 
		{
			// タッチした位置をカメラの中での位置に変換して
			var pos = Camera.main.ScreenToWorldPoint(Input.mousePosition + Camera.main.transform.forward);
			// プレハブを作ってその位置の手前に表示する
			GameObject newGameObject = Instantiate(newPrefab) as GameObject;
			pos.z = newZ;
			newGameObject.transform.position = pos;
		}
	}
}
