using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// タッチすると、アニメーションを再生＆停止
public class OnMouseDownToggleAnime : MonoBehaviour 
{
	//-------------------------------------
	public float speed = 0; //［速度］
	//-------------------------------------

	void Start ()
	{
		this.GetComponent<Animator>().speed = speed;
	}

	void OnMouseDown()  // タッチしたら
	{
		speed = 1 - speed; // 再生と停止を切り換える
		GetComponent<Animator>().speed = speed;
	}
}
