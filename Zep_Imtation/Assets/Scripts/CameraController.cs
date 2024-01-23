using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public GameObject player;
    private Rigidbody2D playerRigidbody;

    private void Start()
    {
        playerRigidbody = player.GetComponent<Rigidbody2D>();

    }

    private void LateUpdate()
    {
        if (playerRigidbody != null)
        {
            // ĳ������ �ӵ��� ��������
            Vector2 playerVelocity = playerRigidbody.velocity;

            // ĳ������ �ӵ��� ������ ���Ͽ� �̵� ���� ���
            Vector2 moveVector = playerVelocity * Time.deltaTime;

            // �ε巯�� �̵� ����
            transform.Translate(moveVector, Space.World);
        }
    }

}






