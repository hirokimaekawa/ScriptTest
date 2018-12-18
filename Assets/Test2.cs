using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

        int[] points1 = new int[5];

        points1[0] = 30;
        points1[1] = 20;
        points1[2] = 50;
        points1[3] = 10;
        points1[4] = 80;

        //（forは、変数初期化；ループしたい範囲；変数の亢進）
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(points1[i]);
        }
        //変数名を複数宣言できないというのは、
        //       このpointのことか？
        string[] points2 = new string[5];

        //Lesson7-4配列の応用的な書き方
        // 配列を初期化する
        int[] points = { 30, 20, 50, 10, 80, 15, 60, 100 };

        // 配列の要素数のぶんだけ処理を繰り返す

        //pointsという名前の変数のLength←これは、変数名？これはLengthという名前でなくてもなんでも大丈夫なのか？
        //"配列の長さ"は配列名.lengthで"取得できる"とはどういうことなのか。
        for (int i = 0; i < points.Length; i++)
        {
            // 配列の要素が50以上の場合
            if (points[i] >= 50)
            {
                // 配列の要素を表示する
                Debug.Log(points[i]);
            }

        }
        // Hello関数を呼び出す
        Hello();

        //Goodbye関数を呼び出す。
        Goodbye();

        // HelloName関数に「Unity」という引数を渡す
        HelloName("Unity");

        HelloNames(8);

        // Add関数に「3」と「6」の引数を渡し、返り値をnum変数に代入する
        int num = Add(3, 6);
        // numを表示する
        Debug.Log(num);

        int sum3 = Add(1, 2, 3);

        Debug.Log(sum3);



    }
    //8-1練習問題

    void Hello()
    {
        Debug.Log("Hello, UnityChan");
    }

    void Goodbye()
    {
        Debug.Log("Hello,Unitychan");
    }

    // 「Hello」に続けて引数の文字列を表示する関数
    void HelloName(string name)
    {
        Debug.Log("Hello, " + name);
    }

    //8-2練習：関数の引数の型をint型に変え、関数を呼び出すときにint型の値を渡して表示してみましょう。
    void HelloNames(int names)
    {
        Debug.Log("Hellos," + names);

    }

    //Add関数は２つの引数を取ります。
    // 第一引数と第二引数の値を足した値を返す関数
    int Add(int a, int b)
    {
        // 第一引数と第二引数の値を足して、変数cに代入する
        int c = a + b;
        // 変数cを呼び出し元の関数に返す
        return c;
    }

    //練習：Add関数に3つ目のint型の引数を追加して引数の合計値を求めて返すように修正してみましょう。
    //また、Start関数から3つの引数を渡してAdd関数を呼び出してみましょう。
    int Add(int d, int e, int g) {
        int f = d + e + g;
        return f;
    }
        
    // Update is called once per frame
    void Update()
    {
    }
}

