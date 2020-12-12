using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //課題①
        int[] newarray = { 11, 111, 1111, 11111, 111111 };

        for(int i = 0; i < 5; i++)
        {
            Debug.Log(newarray[i]);
        }

        for(int i = 0; i < 5; i++)
        {
            Debug.Log(newarray[4 - i]);
        }

        //発展課題
        Boss lastBoss = new Boss();
        //10回Magic()を使用。
        for (int i = 0; i < 10; i++) 
        {
            lastBoss.Magic(); 
        }

        //その後もう一度Magic関数を呼び出す。
        lastBoss.Magic();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Goodbye()
    {
        Debug.Log("Goodbye, Unitychan");
    }

}

public class Boss
{
    int hp = 100;
    int offence = 25;
    int mp = 53;


    public void Attack()
    {
        Debug.Log(this.offence + "のダメージを与えた。");

    }

    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
    }

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
