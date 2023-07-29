using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100; //体力
    private int power = 25; //攻撃力
    private int mp = 53; //魔力



    public void Attack()
    {
        //攻撃用の関数
        Debug.Log(this.power + "のダメージを与えた");
    }
    public void Defence(int damage)
    {
        //防御用の関数
        Debug.Log(damage + "のダメージを受けた");
        //残りhpを減らす
        this.hp -= damage;
    }
    public void Magic()
    {
        for (int i = 0; i < 11; i++)
        {
            if (this.mp >= 5)
            {
                //mpを5以上の場合は5減らし、コンソールに 魔法攻撃をした。残りMPは〇〇。 と表示
                this.mp -= 5;
                Debug.Log("魔法攻撃をした。残りMPは" + this.mp);
            }
            else
            {
                //mpが5未満の場合、MPが足りないため、魔法が使えない。 と表示
                Debug.Log("MPが足りないため、魔法が使えない。");
            }
        }

    }
}

public class Test : MonoBehaviour
{
    //Start is called before the first frame update
    void Start()
    {
        //Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        //攻撃用の関数を呼び出す
        lastboss.Attack();
        //防御用の関数を呼び出す
        lastboss.Defence(3);
        //魔法攻撃用の関数を呼び出す
        lastboss.Magic();
        
    }




    // Update is called once per frame
    void Update()
    　　{
        
    　　}
}
