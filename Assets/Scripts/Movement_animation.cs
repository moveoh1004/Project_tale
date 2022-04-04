using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_animation : MonoBehaviour
{
    public float moveSpeed = 5.0f; //플레이어 이동 속도
    float horizontal;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {


        horizontal = Input.GetAxis("Horizontal");

        if (horizontal != 0)
        {
            animator.SetBool("walk", true);
        }
        else
        {
            animator.SetBool("walk", false);
        }

        Vector3 dir = horizontal * Vector3.right; // transform.Translate() 변수의 자료형을 맞추기 위해 생성한 새로운 Vector3 변수 생성
        this.transform.Translate(dir * moveSpeed * Time.deltaTime); // Player 오브젝트 이동 함수
    }
}
