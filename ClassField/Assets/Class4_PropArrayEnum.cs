﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//定義列舉
//定義在類別外可以讓所有類別使用
//下拉式選單
//列舉預設為整數 從0開始
public enum Season
{
    Spring, Summer, Fall, Winter
}

public enum State
{
    Idle, Walk, Attack, Damage, Skill, Dead
}

//自行變更編號
//Sunday為7，Minday為1，後面遞增

public enum Day
{
    Sunday = 7,Monday=1,Tuesday,Wensday,Thursday,Friday,Saturday
}


public class Class4_PropArrayEnum : MonoBehaviour
{

    public Season _season;
    public State _state;
    public Day _day;

    public Ship ship;

    //一般欄位
    public string name1 = "11";
    public string name2 = "22";

    //陣列:類型[]
    //Unity屬性面板上size指的是數量
    //Element為陣列成員 編號從0開始
    public string[] names;                                           //宣告陣列不指定數量

    public float[] weights = new float[3];                     //宣告陣列並指定數量

    public int[] scores = new int[] {10,20,30,50,90};   //宣告陣列並指定內容

    public bool[] mission = { true, true, false };           //宣告陣列並指定內容


    //喚醒事件 : start之前執行一次
    private void Awake()
    {
        //取得列舉
        print("季節:" + _season);
        print("狀態:" + (int)_season);        //(int)將列舉轉型為整數
        print("日期:" + (int)_day);
        //存放列舉
        _state = State.Walk;
    }


    private void Start()
    {

        //設定屬性
        ship.length = 99.9f;
        //取得屬性
        print(ship.length);

        //設定唯獨屬性
        //ship.width = 20.5f; //錯誤
        //取得唯獨屬性
        print("船的寬度 :" + ship.width);

        ship.atk = 50.3f;
        print("船的攻擊力 :" + ship.atk);

        ship.def = 10.1f;
        print("船的防禦力 :" + ship.def);

        //指定陣列資料
        names = new string[ ] { "怪物A", "怪物B", "怪物C" };

        //陣列存放
        scores[0] = 77;
        //陣列取得
        print("取得怪物陣列第三筆資料" + name[2]);

        //陣列.Length 長度(數量)
        print("分數陣列的長度(數量):" + scores.Length);

        //呼叫改變分數方法並將分數陣列傳進方法內
        ChangeScore(scores);

        TestValue(A);
        TestRefe(B);
    }

    //陣列為參考型別
    /// <summary>
    /// 改變第二筆分數為99
    /// </summary>
    /// <param name="theArray"></param>
    private void ChangeScore(int[] theArray)
    {
        theArray[1] = 99;
    }

    //整數為實值型別
    public int A = 99;
    //陣列為參考型別
    public int[] B = { 99 };

    /// <summary>
    /// 測試實值型別:傳值 -傳資料近來，不會修改原本資料
    /// </summary>
    /// <param name="test"></param>
    private void TestValue(int test)
    {
        test = 0;
    }

    /// <summary>
    /// 測試參考型別: 傳址 - 傳地址進來，會修改原本資料
    /// </summary>
    /// <param name="test"></param>
    private void TestRefe(int[] test)
    {
        test[0] = 0;
    }



}
