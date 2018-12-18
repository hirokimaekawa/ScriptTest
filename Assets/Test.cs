using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    // Use this for initialization
    //void HelloName(int name){
    //Debug.Log("Hello," + name);}

    //void Start()
    //{
    // HelloName(483920);
    //}

    // Update is called once per frame
    //void Update()
    //{

    //}
    //}

    // private void Start()
    //{
    // Debug.Log("Hello,World");
    //}「Start」関数に処理を集めると、処理を２つ以上行える。

    void Start()
    {
        //変数intの宣言
        int score;
        //変数の代入
        score = 150;
        //コンソールに変数の中身を表示
        Debug.Log(score);
        Debug.Log("Hello,World");

        int a = 3;
        int b = 4;
        int c = a + b;
        Debug.Log(c);

        int money = 150;
        if (money >= 200)
        {
            Debug.Log("武器を買う");
        }
        else if (money <= 50)
        {
            Debug.Log("武器を売る");
        }
        else
        {
            Debug.Log("ポーションを買う");
        }
        //int num = 1;
        //int val = (num == -1) ? -100 : 100;
        //Debug.Log(val);

        int val;
        int num = 1;
        if (num == 1)
        {
            val = -100;
        }
        else
        {
            val = 100;
        }
        Debug.Log(val);

        if (a == 3)
        {
            int d = 5;
            Debug.Log(d);
        }
        //for文
        //for(変数初期化；ループ条件式；変数の亢進)｛
        //繰り返したい処理
        //｝

        //処理を５回繰り返す
        for(int i = 0 ;
            //iが４まで繰り返す
            i < 5; 
            //「++」は変数の値を１つ増やす
            i++)
        {
            Debug.Log(i);
        }
        //sumを0で初期化する
        int sum = 0;
        //初期化した変数値が0だから、１０回繰り返す
        for(int i = 1; i <= 10; i++)
        {
            //変数iの値を+1します。
            sum += i;
        }
        Debug.Log(sum);
        
    }
}

