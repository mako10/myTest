using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// キーを押すと、プレハブを作って投げる
public class OnKeyPressThrow : MonoBehaviour 
{
	//-------------------------------------
	public GameObject newPrefab; //［作るプレハブ］
    public InputKey FireKey = InputKey.Submit; // プルダウンメニューで選択するキー
    public Vector2 power = new Vector2(6, 6); //［投げる力］
    public Vector2 offset = new Vector2(0.7f, 1); //［オフセット］
    public int newZ = -5; //［描画順］
	//-------------------------------------
	bool pushFlag = false;
	bool leftFlag = false;

	void Update() 
	{
        float h = Input.GetAxisRaw("Horizontal");
        if (h < 0)  // 左キーなら
		{
            leftFlag = true;
        }
        else if (h > 0)  // 右キーなら
		{
            leftFlag = false;
        }
		if (Input.GetButtonDown(FireKey.ToString()))  // 指定キーなら
		{
			if (pushFlag == false)  // 押しっぱなしでなければ
			{
				pushFlag = true;
				Vector3 area = GetComponent<SpriteRenderer>().bounds.size;
				Vector3 newPos = transform.position;
				// プレハブを作ってその位置の手前に表示する
				GameObject newGameObject = Instantiate(newPrefab) as GameObject;
				if (leftFlag)  // 左向きなら逆方向に投げる
				{
					newPos.x -= offset.x; // 位置を調整
				}
				else 
				{
					newPos.x += offset.x; // 位置を調整
				}
				newPos.y += offset.y; // 位置を調整
				newPos.z = newZ; // 描画順を設定
				newGameObject.transform.position = newPos;

				Rigidbody2D rbody = newGameObject.GetComponent<Rigidbody2D>();
				if (leftFlag)  // 左向きなら逆方向に
				{
					rbody.AddForce(new Vector2(-power.x, power.y), ForceMode2D.Impulse);
				}
				else 
				{ // 右向きなら右向きに
					rbody.AddForce(new Vector2(power.x, power.y), ForceMode2D.Impulse);
				}
			}
		} 
		else 
		{
			pushFlag = false;
		}
	}
}
