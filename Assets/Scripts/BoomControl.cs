using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomControl : MonoBehaviour
{
    // 碰撞开始
    void OnCollisionEnter(Collision collision)
    {
        Debug.LogWarning("星球" + this.name + "发生碰撞");
    }
}
