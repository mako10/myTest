using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ずっと、マウスを追いかける
public class ForeverChaseMouse : MonoBehaviour 
{
	//-------------------------------------
    public int drawOrder = 100; //［描画順］
	//-------------------------------------
	void Start () 
	{
		GetComponent<SpriteRenderer>().sortingOrder = drawOrder; // 手前に表示
	}

	void Update () 
	{
		Vector3 position = Input.mousePosition;
		position.z = 10f; // 他のものへのタッチに影響しないように奥へ
		gameObject.transform.position = Camera.main.ScreenToWorldPoint(position);
	}
}