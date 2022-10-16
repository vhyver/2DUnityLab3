using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimTriggers : MonoBehaviour
{

    Animator anim;
    // Start is called before the first frame update
    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    void ResetAnimation()
    {
        anim.SetBool("isRun", false);
        anim.SetBool("isJump", false);
    }
    public void Idle()
    {
        ResetAnimation();
        anim.SetTrigger("idle");
    }

    public void Run()
    {
        ResetAnimation();
        anim.SetBool("isRun", true);

    }
    public void Jump()
    {
        ResetAnimation();
        anim.SetBool("isJump", true);

    }
}
