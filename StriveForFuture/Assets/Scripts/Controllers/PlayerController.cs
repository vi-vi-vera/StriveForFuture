using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    PlayerVo player;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        player = PlayerMoudel.Instance.Player;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        
    }

    private void Move()
    {
        //键盘WASD键控制人物移动
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        if (horizontal == 0 && vertical == 0)
        {
            //如果人物在原地
            animator.SetBool("isRunning", false);
        }
        else
        {
            //如果人物发生了移动
            animator.SetBool("isRunning", true);
            Vector3 moveDir = new Vector3(horizontal, vertical, 0);
            moveDir = transform.TransformDirection(moveDir);//将一个世界坐标的方向转化为当前的局部方向
            transform.position += moveDir.normalized * player.Agility * 0.1f * Time.deltaTime;
            animator.SetFloat("moveX", moveDir.x);
            animator.SetFloat("moveY", moveDir.y);
        }
    }
}
