using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// キーを押すと、近くにプレハブを作る
public class OnKeyPressCreatePrefab : MonoBehaviour 
{
	//-------------------------------------
	public GameObject newPrefab; //［作るプレハブ］
    public InputKey FireKey = InputKey.Submit; // プルダウンメニューで選択するキー
    public Vector2 offset = new Vector2(0.7f, 0); //［オフセット］
    public int newZ = -5; //［描画順］
	//-------------------------------------
	bool pushFlag = false;
	bool leftFlag = false;

	void Update ()
	{
        float h = Input.GetAxisRaw("Horizontal");
        if (h < 0) // 左キーなら
		{
            leftFlag = true;
        }
        else if (h > 0)  // 右キーなら
		{
            leftFlag = false;
        }
		if(Input.GetButtonDown(FireKey.ToString())) // もし、キーが押されたら
		{
			if (pushFlag == false) 
			{
				pushFlag = true;
				// プレハブを作ってその位置の手前に表示する
				GameObject newGameObject = Instantiate(newPrefab) as GameObject;
				Vector3 newPos = transform.position;
				if (leftFlag)  // 左向きなら逆方向に投げる
				{
					newPos.x -= offset.x; // 位置を調整
				} 
				else 
				{
					newPos.x += offset.x; // 位置を調整
				}				newPos.y += offset.y;
				newPos.z = newZ;
				newGameObject.transform.position = newPos;
			}
		}
		 else 
		{
			pushFlag = false;
		}
	}

}
