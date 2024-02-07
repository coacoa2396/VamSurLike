using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    Vector2 inputVec;
    public Rigidbody2D rigid;

    public float speed;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

    }

    private void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        Vector2 nextVec = inputVec.normalized * speed * Time.fixedDeltaTime;
        // 3. 위치 이동
        rigid.MovePosition(rigid.position + nextVec);
    }
    void OnMove(InputValue value)
    {
        Vector2 input = value.Get<Vector2>();
        inputVec.x = input.x;
        inputVec.y = input.y;
    }
}
