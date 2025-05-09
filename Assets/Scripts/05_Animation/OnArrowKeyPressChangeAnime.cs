using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// キーを押すと、アニメーションを切り換える
public class OnArrowKeyPressChangeAnime : MonoBehaviour 
{
	//-------------------------------------
	public string upAnime = "";		//［上向きアニメ］
	public string downAnime = "";	//［下向きアニメ］
	public string rightAnime = "";	//［右向きアニメ］
	//-------------------------------------
	string nowMode = "";
	string oldMode = "";
	Animator animator;

	void Start()
	{
		animator = GetComponent<Animator>();
		nowMode = downAnime;
	}

    void Update()
	{
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        if (v > 0)
		{
            nowMode = upAnime; // 上キーの場合
        }
		else if (v < 0)
		{
            nowMode = downAnime; // 下キーの場合
        }
		else if (h > 0)
		{
            nowMode = rightAnime; // 右キーの場合
        }
		else if (h < 0)
		{
            nowMode = rightAnime; // 左キーの場合
        }
		if (nowMode != oldMode)
		{
			oldMode = nowMode;
			animator.Play(nowMode); // アニメを切り換える
		}
	}
}