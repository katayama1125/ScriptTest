using System.Collections;
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

    // 魔法攻撃用の関数
    public void Magic()
    {

        this.mp -= 5;
        if (mp >= 3)
        {
            Debug.Log("魔法攻撃をした。残りMPは" + mp);
        }
        else
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }

    }

    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");

        this.hp1 -= damage;
    }

}
