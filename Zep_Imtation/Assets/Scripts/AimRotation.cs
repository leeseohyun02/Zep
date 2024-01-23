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

    private void RotateAim(Vector2 direction) // ���콺 �������� �ٶ󺸰� �ϱ�
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg; //���� ���� ������
        
        characterRenderer.flipX = Mathf.Abs(rotZ)>90f; //90���� �Ѿ�� ����������

    }
}
