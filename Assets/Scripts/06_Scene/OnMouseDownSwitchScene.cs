using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;	// シーン切り替えに必要

// タッチすると、シーンを切り換える
public class OnMouseDownSwitchScene : MonoBehaviour 
{
	//-------------------------------------
	public string sceneName;  //［シーン名］
	//-------------------------------------

	void OnMouseDown() // タッチしたら
	{
		SceneManager.LoadScene(sceneName); // シーンを切り換える
	}
}
