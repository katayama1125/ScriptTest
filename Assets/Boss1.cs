﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss1
{
    private int hp1 = 50;          // 体力
    private int power1 = 15; // 攻撃力
    private int mp = 33;

    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power1 + "のダメージを受けた");
    }

    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");

        this.hp1 -= damage;
    }

}
