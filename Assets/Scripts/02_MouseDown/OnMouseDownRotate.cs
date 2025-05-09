using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// タッチすると、回転する
public class OnMouseDownRotate : MonoBehaviour 
{
	//-------------------------------------
	public float angle = 360; //［角度］
	//-------------------------------------
	float rotateAngle = 0;

	void OnMouseDown()  // タッチしたら
	{
		rotateAngle = angle; // 回転量を指定する
	}

	 void OnMouseUp()  // タッチをやめたら
	{
		rotateAngle = 0; // 回転量を0にする
	}

	void FixedUpdate()
	{
		transform.Rotate(0, 0, rotateAngle * Time.deltaTime);	// 回転する
	}
}
