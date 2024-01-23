using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimaitionController : Animation
{

    private static readonly int IsWalking = Animator.StringToHash("IsWalking");
    
    void Start()
    {
        _controller.OnMoveEvent += Move;   
    }


    private void Move(Vector2 obj)
    {
        animator.SetBool(IsWalking, obj.magnitude > .5f) ;
    }

}
