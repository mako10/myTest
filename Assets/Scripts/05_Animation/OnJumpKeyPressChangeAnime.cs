using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ジャンプキーを押すと、アニメーションを切り換える
public class OnJumpKeyPressChangeAnime : MonoBehaviour 
{
    //-------------------------------------
    public InputKey jumpKey = InputKey.Jump; // プルダウンメニューで選択するキー
    public string AnimeName = ""; //［ジャンプアニメ］
    public string defaultAnimeName = ""; //［元のアニメ］
    //-------------------------------------
    private Animator animator;
    private bool isPlaying = false;

    void Start() 
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetButtonDown(jumpKey.ToString()))  // 指定キーが押されたら
        {
            isPlaying = true;
            animator.Play(AnimeName); // ジャンプアニメを再生
        }

        // 現在のアニメーションがジャンプアニメーションかどうかを確認する
        if (isPlaying && IsAnimationFinished(AnimeName)) 
        {
            isPlaying = false;
            animator.Play(defaultAnimeName); // 元のアニメに戻る
        }
    }

    bool IsAnimationFinished(string animationName) 
    {
        AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);
        return stateInfo.IsName(animationName) && stateInfo.normalizedTime >= 1.0f;
    }
}
