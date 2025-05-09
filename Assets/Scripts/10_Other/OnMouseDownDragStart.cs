using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// タッチすると、ドラッグ開始する
public class OnMouseDownDragStart: MonoBehaviour 
{
	//-------------------------------------
    public int drawOrder = 100; //［描画順］
	//-------------------------------------
	bool dragFlag = false;

	void OnMouseDown() 
	{
		dragFlag = true;
        GetComponent<SpriteRenderer>().sortingOrder = drawOrder; // 手前に表示
	}

	void OnMouseUp() 
	{
		dragFlag = false;
	}

	void Update()
	{
		if (dragFlag) 
		{
			Vector3 position = Input.mousePosition;
			position.z = 10f; // 他のものへのタッチに影響しないように奥へ
			gameObject.transform.position = Camera.main.ScreenToWorldPoint(position);
		}
	}
}
