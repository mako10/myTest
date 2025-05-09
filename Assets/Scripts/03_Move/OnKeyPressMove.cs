using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// キーを押すと、移動する 
public class OnKeyPressMove : MonoBehaviour 
{
	//-------------------------------------
	public float speed = 5f; //［速度］
	//-------------------------------------
	float vx;
	float vy;
	Rigidbody2D rbody;
	bool leftFlag;

    void Start ()
    {
        rbody = GetComponent<Rigidbody2D>();
        rbody.gravityScale = 0;  // 重力を0にして、衝突時に回転させない
        rbody.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

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
		rbody.linearVelocity = new Vector2(vx, vy); // 移動する
        GetComponent<SpriteRenderer>().flipX = leftFlag; // 向きを変える
	}
}
