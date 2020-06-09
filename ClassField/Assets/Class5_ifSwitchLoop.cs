using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Class5_ifSwitchLoop : MonoBehaviour
{

    public bool openDoor;
    public float score;
    [Header("血量"),Range(0,100)]
    public int hp=100;

    public string prop = "紅水";
    public Season season;

    [Header("道具數量")]
    public int count;
    [Header("任務完成數量")]
    public bool complete;

    public int i = 1;
    public int j = 1;

    //GameObject 可存放階層面板或專案內的模型
    [Header("地板")]
    public GameObject cube;

    public int[] scores={100,99,88,77,66};

    private void CreateFloor(int length,int width)
    {
        for (int j = 0; j < width; j++)
        {
            for (int i = 0; i < length; i++)
            {
                //API實例化 (生成)
                //生成(物件,座標,角度)
                //Vector3 三維向量
                //Quaternion 角度
                //Quaternion.identity 零角度
                //Quaternion.Euler(x,y,z) 歐拉角度 - 0~360度
                Instantiate(cube, new Vector3(j*2, 0, i * 2), Quaternion.Euler(270, 0, 0));

            }
        }
    }

    private void Awake()
    {

        for (int i = 0; i < 101; i++)
        {
            print("break 迴圈 : " + i);

            //如果i等於10就打斷迴圈並執行迴圈下方的程式
            if(i==10)
            {
                break;
            }
        }
        print("break迴圈外的程式");




        for (int i = 0; i < 101; i++)
        {
            print("return 迴圈 : " + i);

            //如果i等於10就打斷迴圈並不執行迴圈下方的程式
            if (i == 10)
            {
                return;
            }
        }
        print("return");

        //continue 執行結果:0-4 6-19 迴圈外的程式
        for (int i = 0; i < 20; i++)
        {
            if (i == 5) continue;
            print("continue迴圈 : " + i);
        }
        print("continue迴圈外的程式");



        for (int i = 0; i < 10; i++)
        {
            if (i == 5) goto Test;
            {
                print("goto 迴圈 : " + i);
            }
        }
    Test:
        print("這是標記陳述式");


        //使用for迴圈取得陣列資料
        for (int i = 0; i < scores.Length; i++)
        {
            print("for迴圈取得陣列資料 : " + scores[i]);

        }

        //foreach迴圈
        //語法:foreach(取得資料的類型 取得資料的名稱 in 陣列){執行次數為陣列數量}
        foreach (int item in scores)
        {
            print("foreach迴圈取得陣列資料 : " + item);
        }



        CreateFloor(30,3);

        //While迴圈
        //while (布林值) {當布林值為true執行}
        //迴圈之前評估，第一次判斷i=1
        while (i<=10)
        {
            print("while迴圈第 :" + i + "次");
            i++;
        }

        //迴圈之後評估，第一次判斷J=2
        do
        {
            print("while迴圈第 :" + j + "次");
            j++;
        } while (j<=10);


        for (int k = 0; k < 10; k++)
        {
            print("for 迴圈第 : " + k + "次");
        }
        for (int k = 10; k < 1; k--)
        {
            print("for 迴圈倒數第 : " + k + "次");
        }


    }


    private void Start()
    {
        //if 判斷式
        //if (布林值) {布林值=true時執行}
        if(true)
        {
            print("我是IF判斷式");
        }

    }


    private void Update()
    {
        //當道具數量>=5 任務完成true
        //三元運算子語法 - 布林運算式 ? 運算式A:運算式B
        //指派、呼叫=()
        complete = count >= 5 ? true : false;
        



        switch (prop)
        {
            case "紅水":
                print("補HP");
                break;
            case "藍水":
                print("補MP");
            break;

         }

        switch (season)
        {
            case Season.Spring:
                print("春");
                break;
            case Season.Summer:
                print("夏");
                break;
            case Season.Fall:
                print("秋");
                break;
            case Season.Winter:
                print("冬");
                break;



            default:
                break;
        }



        if(hp<=100 && hp >70)
        {
            print("安全");
        }
        else if(hp<70 &&hp>=20)
        {
            print("警告");
        }
        else
        {
            print("危險");
        }



        /*
        if(openDoor)
        {
            print("開門");
        }
        else
        {
            print("關門");
        }


        if(score > 60)
        {
            print("及格");
        }
        else
        {
            print("不及格");
        }
        */




    }

}
