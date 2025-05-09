using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// キーを押すと、移動する（ジャンプ版）
public class OnKeyPressMoveGravity : MonoBehaviour 
{
	//-------------------------------------
    public InputKey jumpKey = InputKey.Jump; // プルダウンメニューで選択するキー
    public float speed = 5f; //［スピード］
    public float jumppower = 8f; //［ジャンプ力］
    public float checkDistance = 0.1f; //［地面チェックの距離］
    public float footOffset = 0.01f; //［足元位置のオフセット］
    //-------------------------------------
    Rigidbody2D rbody;
    float vx = 0;
    bool leftFlag;
    bool isGrounded;
    bool isJumping = false;

    void Start() 
    {
        rbody = GetComponent<Rigidbody2D>();
        rbody.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    void Update() 
    {
        // 左右キーで移動
        vx = 0;
        vx = Input.GetAxisRaw("Horizontal") * speed;

        if (vx != 0) 
        {
            leftFlag = vx < 0;
        }
        rbody.linearVelocity = new Vector2(vx, rbody.linearVelocity.y);
        GetComponent<SpriteRenderer>().flipX = leftFlag;

        // 足の下が何かに触れているかを調べる
        float myHeight = GetComponent<Collider2D>().bounds.extents.y;
        float footy = transform.position.y - myHeight - footOffset;
        Vector2 startRay = new Vector2(transform.position.x, footy);
        isGrounded = Physics2D.Raycast(startRay, Vector2.down, checkDistance);

        // ジャンプキーが押されて、着地していて、ジャンプ中でなければジャンプ
        if (Input.GetButtonDown(jumpKey.ToString()) && isGrounded && !isJumping) 
        {
            isJumping = true;
            rbody.AddForce(new Vector2(0, jumppower), ForceMode2D.Impulse);
        }
        if (rbody.linearVelocity.y <= 0) 
        {
            isJumping = false; // 上昇をやめたらジャンプ中を解除
        }
    }
}
