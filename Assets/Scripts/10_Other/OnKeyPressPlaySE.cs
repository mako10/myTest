using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// キーを押すと、SEが鳴る
public class OnKeyPressPlaySE : MonoBehaviour 
{
	//-------------------------------------
	public string inkey = "a"; //［押すキー］
	public AudioClip se; //［鳴らすSE］
	//-------------------------------------
	bool pushFlag = false;
	
	void Update () 
	{
		if(Input.GetKey(inkey)) // もし、キーが押されたら
		{
			if (pushFlag == false) 
			{
				pushFlag = true;
				gameObject.GetComponent<AudioSource>().PlayOneShot(se);
			}
		} 
		else
		{
			pushFlag = false;
		}
	}
}
