using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Class6_StaticAPI : MonoBehaviour
{

    public _Enemy zombie1, zombie2;
    public GameObject obj1;
    public Light myLight;
    public Transform tran1;

    // Start is called before the first frame update
    private void Start()
    {
        //一般欄位
        //取得方法 : 物件，欄位
        print(zombie1.name + "血量 : " + zombie1.hp);
        print(zombie2.name + "血量 : " + zombie2.hp);

        //靜態欄位
        //取得方式 : 類別，靜態欄位
        print( "僵屍的速度 : " + _Enemy.speed);

        //無法透過物件取得靜態欄位(錯誤)
        //print(zombie1.speed);

        //使用一般方法
        //物件、方法
        zombie1.Walk();
        zombie2.Walk();

        //使用靜態方法
        //類別、靜態方法
        _Enemy.Stop();


        //存放 靜態 屬性
        //類別.靜態屬性 = 值
        Cursor.visible = false;

        print(Mathf.PI);

        print(Random.value);

        print("絕對值 : " + Mathf.Abs(-77.7f));

        print("隨機範圍 : " + Random.Range(1f, 100f));

        print("隨機整數 : " + Random.Range(1, 3)); //整數不會出現最大值


        //錯誤:非靜態不能透過類別存取
        //print(GameObject.layer);

        //靜態屬性與非靜態屬性的區別
        //靜態屬性 不需要新增欄位 - Random、value
        //非靜態屬性 需要新增欄位 - public GameObject obj1;    obj1.layer;

        //非靜態 屬性
        //物件名稱.非靜態屬性
        print(obj1.layer);

        //非靜態 需要有實體物件 - 存在遊戲場景內的物件
        print(myLight.color);

        tran1.localScale = Vector3.one * 5;

    }

    // Update is called once per frame
    void Update()
    {
        //原本用法: 字串
        print("玩家是否按空白鍵 : " + Input.GetKeyDown("space"));
        //多載1 : 列舉
        print("玩家是否按右鍵 : " + Input.GetKeyDown(KeyCode.Mouse1));

        //非靜態方法
        //物件名稱，非靜態方法(對應的引數)
        tran1.Rotate(0, 0, 10);

    }
}
