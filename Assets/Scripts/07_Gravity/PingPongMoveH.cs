using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 行ったり来たり移動する（水平）
public class PingPongMoveH : MonoBehaviour 
{
	//-------------------------------------
    public float speed = 1.0f; //［速度］
    public float moveTime = 2.0f; //［移動時間］
	//-------------------------------------
	Rigidbody2D rbody;
    private float timer = 0.0f;

	void Start ()
    {
		// 重力や外力の影響を受けずにスクリプトで移動
		rbody = GetComponent<Rigidbody2D>();
        rbody.bodyType = RigidbodyType2D.Kinematic;
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= moveTime) 
        {
            speed = -speed; // 方向転換
            timer = 0.0f;
        }
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
}
