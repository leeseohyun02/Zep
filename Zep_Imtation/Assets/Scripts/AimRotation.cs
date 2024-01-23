using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimRotation : MonoBehaviour
{
    [SerializeField] private SpriteRenderer characterRenderer;

    private CharacterController _controller;

    private void Awake()
    {
        _controller = GetComponent<CharacterController>();
    }

    void Start()
    {
        _controller.OnLookEvent += OnAim;
    }

    public void OnAim(Vector2 newAimDirection)
    {
        RotateAim(newAimDirection);
    }

    private void RotateAim(Vector2 direction) // 마우스 방향으로 바라보게 하기
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg; //라디안 값을 각도로
        
        characterRenderer.flipX = Mathf.Abs(rotZ)>90f; //90도가 넘어가면 뒤집어지게

    }
}
