using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//    クラス型　クラス名（変数名）
public class Boss
{
    //private int hp = 100;          // 体力
    //private int power = 25; // 攻撃力

    //int型の変数mpを宣言し、53で初期化してください
    private int mp = 53;

    // 攻撃用の関数
    //public void Attack()
    //{
      //  Debug.Log(this.power + "のダメージを与えた");
    //}

    // 防御用の関数
    //public void Defence(int damage)
    //{
        //Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        //this.hp -= damage;
    //}

    //mpを消費して魔法攻撃をするMagic関数を作ってください
    public void Magic()
    {
        if (mp >= 5)
        {
            mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + mp);
        }
        else
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }
}

//int型の変数mpを宣言し、53で初期化してください
//mpを消費して魔法攻撃をするMagic関数を作ってください
//Magic関数内で☆mpを5減らし☆、コンソールに「魔法攻撃をした。残りMPは〇〇。」と表示してください。
//mpが足りない場合、「MPが足りないため魔法が使えない。」と表示してください
public class Test3 : MonoBehaviour
{
    //練習：新しくBossクラスのmidboss変数を作り、Attack関数やDefence関数を呼び出してみましょう。

    // Use this for initialization
    void Start()
    {
        // Bossクラスの変数を宣言してインスタンスを代入
        //Boss lastboss = new Boss();

        // 攻撃用の関数を呼び出す
        //lastboss.Attack();
        // 防御用の関数を呼び出す
        //lastboss.Defence(3);

        //練習：新しくBossクラスのmidboss変数を作り、Attack関数やDefence関数を呼び出してみましょう。

        Boss midboss = new Boss();
        //midboss.Attack();
       // midboss.Defence(5);

        // 11回呼び出すfor
        for (int i = 0; i < 11; i++)
        {
            midboss.Magic();
        }

        // 1回だけ呼び出す方法
        // midboss.Magic();

        // 自分のクラスに関数が定義されている場合
        // Test();
    }

    //void Test()
    //{

   // }

    // Update is called once per frame
    void Update()
    {

    }
}