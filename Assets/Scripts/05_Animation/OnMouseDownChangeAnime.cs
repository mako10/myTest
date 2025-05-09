using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// タッチすると、アニメーションを切り換える
public class OnMouseDownChangeAnime : MonoBehaviour 
{
	//-------------------------------------
	public string normalAnime = "";	//［通常アニメ］
	public string nextAnime = "";	//［次のアニメ］
	//-------------------------------------
	bool touchFlag = false;

	void OnMouseDown() // タッチしたら
	{
		touchFlag = !touchFlag;
		Animator animator = GetComponent<Animator>();
		if (touchFlag == true) { // 次のアニメに切り換える
			animator.Play(nextAnime);
		}
		else
		{ // もう一度タッチしたら元のアニメに切り換える
			animator.Play(normalAnime);
		}
	}
}
