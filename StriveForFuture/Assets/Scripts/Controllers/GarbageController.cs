using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarbageController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    /// <summary>
    /// 当玩家碰到垃圾时，将垃圾放入玩家背包
    /// </summary>
    /// <param name="other"></param>
    void OnTriggerEnter2D(Collider2D other)
    {
        PlayerController pc = other.GetComponent<PlayerController>();
        if (pc != null)
        {
            //向背包中添加垃圾
            GarbageVo garbage = GarbageModel.Instance.GetGarbageById(int.Parse(transform.name));
            GarbageModel.Instance.AddGarbage(garbage.Clone());
            Destroy(this.gameObject);
        }
    }
}
