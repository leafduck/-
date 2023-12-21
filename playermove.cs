using UnityEngine;

public class playermove : MonoBehaviour
{
    public float moveSpeed = 5f; // 이동 속도 조절 변수
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // 수평 및 수직 입력을 받아 이동 방향을 설정
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector2 moveDirection = new Vector2(horizontalInput, verticalInput).normalized;

        // 이동 방향에 따라 실제 이동 처리
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }
}
