using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// キーを押すと、スプライトが移動する
public class OnKeyPressMoveSprite : MonoBehaviour 
{
	//-------------------------------------
	public float speed = 5f; //［速度］
	//-------------------------------------
	float vx;
	float vy;
	bool leftFlag;

	void Update ()
	{
        // 上下左右キーを調べる
        vx = Input.GetAxisRaw("Horizontal") * speed;
        vy = Input.GetAxisRaw("Vertical") * speed;

        if (vx != 0) // 左右の向きを変えるフラグを設定
		{
            leftFlag = vx < 0;
        }
	}

	void FixedUpdate()
	{
        transform.Translate(vx * Time.deltaTime, vy * Time.deltaTime, 0);
        GetComponent<SpriteRenderer>().flipX = leftFlag; // 向きを変える
	}
}
