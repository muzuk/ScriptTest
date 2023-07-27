using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Test : MonoBehaviour
{
    //Start is called before the first frame update
    void Start()
    {
        //要素の個数が5の、int型の配列arrayを宣言して好きな値で初期化
        int[] array= { 0, 1, 2, 3, 4 };

        //for文を使い、配列の各要素の値を順番に表示
        for (int i = 0; i<array.Length; i++)
        {
            Debug.Log(array [i]);
        }
        //for文を使い、配列の各要素の値を逆順に表示
        for (int i = 4; i<array.Length; i--)
        {
            Debug.Log(array[i]);
        }
    }



    // Update is called once per frame
    void Update()
    　　{
        
    　　}
}
