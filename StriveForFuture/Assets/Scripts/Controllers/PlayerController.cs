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
        player = PlayerModel.Instance.Player;
        animator = GetComponent<Animator>();

        animator.SetBool("isRunning", false);
    }

    // Update is called once per frame
    void Update()
    {
        //移动
        Move();
        //指令解析，按键并做对应动作
        InstructionParse();
    }

    private void Move()
    {
        //键盘控制人物移动
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

    private void InstructionParse()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            //丢垃圾
            animator.SetTrigger("Throw");
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            //人物坐下
            animator.SetTrigger("Sit");
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //按空格站起来
            animator.SetTrigger("Stand");
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            //人物哭泣
            animator.SetTrigger("Cry");
        }

    }
}
