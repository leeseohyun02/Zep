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
            // 캐릭터의 속도를 가져오기
            Vector2 playerVelocity = playerRigidbody.velocity;

            // 캐릭터의 속도와 방향을 곱하여 이동 벡터 계산
            Vector2 moveVector = playerVelocity * Time.deltaTime;

            // 부드러운 이동 적용
            transform.Translate(moveVector, Space.World);
        }
    }

}






