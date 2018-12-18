using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Challenge : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        //要素の個数が5の、int型の配列arrayを宣言して好きな値で初期化してください
        //for文を使い、配列の各要素の値を順番に表示してください
        // 要素数5の配列を初期化する

        int[] array = new int[5];

        array[0] = 10;
        array[1] = 20;
        array[2] = 30;
        array[3] = 40;
        array[4] = 50;
        //for (int i = n-1; i >= 0; i--)
        for (int i = 0; i <= 4; i++)
        {
            Debug.Log(array[i]);
        }
        for (int i = 4; i >= 0; i--)
        {
            Debug.Log(array[i]);

        }
        //for文を使い、配列の各要素の値を逆順に表示してください 
        //for (int i = 4; i >= 0; i++)
        //{
        //for(最初の変数の状態;i=5から-1する条件（i=0まで行う。）；ループが一回終わるとそれを繰り返す)
        //for (int i = 4; array.Length - 1 >= 0; i++)
        //{

        // Debug.Log(array[i]);
        //}


    }


    // Update is called once per frame
    void Update()
    {

    }

}