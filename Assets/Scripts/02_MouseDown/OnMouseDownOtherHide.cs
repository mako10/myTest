using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// タッチすると、他のものを消す
public class OnMouseDownOtherHide : MonoBehaviour
{
	//-------------------------------------
	public GameObject hideObject; //［消すオブジェクト］
	//-------------------------------------
	void OnMouseDown()  // タッチしたら
	{
    	hideObject.SetActive(false); // 他のものを消す
	}
}
