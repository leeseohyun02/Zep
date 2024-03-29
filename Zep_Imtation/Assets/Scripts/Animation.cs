using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    protected Animator animator;
    protected CharacterController _controller;

    protected virtual void Awake()
    {
        animator = GetComponentInChildren<Animator>();
        _controller = GetComponent<CharacterController>();
    }
}
