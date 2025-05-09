using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// タッチすると、ルーレットのように回転する
public class OnMouseDownRoulette : MonoBehaviour 
{
	//-------------------------------------
	public float maxSpeed = 50; //［最大速度］
	//-------------------------------------
	float rotateAngle = 0;

	void OnMouseDown()  // タッチしたら
	{
		rotateAngle = maxSpeed; // 最大スピードを出す
	}

	void FixedUpdate() 
	{
		rotateAngle = rotateAngle * (float)0.98; // 少しずつ減らして
		transform.Rotate(0,0,rotateAngle); // 回転する
	}
}
