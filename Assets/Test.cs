
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int mp = 53;   //mp初期値

    //魔法攻撃関数
    public void Magic()
    {
        this.mp -= 5; //消費mp

        if (mp > 5) {
            Debug.Log("魔法攻撃をした。残りMPは" + mp);
        }
        else
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }

    }

}

public class Test : MonoBehaviour {

	void Start () {

        Boss lastBoss = new Boss();

        for (int i = 0; i < 10; i++)
        {
            //魔法攻撃関数の呼び出し
            lastBoss.Magic();
        }

        // 課題
        int[] array = { 1, 2, 3, 4, 5 };
        for (int i= 0; i< 5; i++)
        {
            Debug.Log(array[i]);
        }
        for (int i = 4; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
