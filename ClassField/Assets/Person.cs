using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person : MonoBehaviour
{
    [Header("身高")]
    public float height;
    [Header("體重")]
    public float weight;


    // 定義方法語法:
    //修飾詞 傳回類型 方法名稱 (參數) {陳述式}
    //void 無傳回 : 使用此方法時不會得到任何傳回資料

    public void Talk()
    {
        //gameObject 套用此腳本的物件
        //gameObject.name 套用此腳本的物件的名稱
        print("我在說話，我是" + gameObject.name);
    }

    /// <summary>
    /// 計算BMI
    /// </summary>
    /// <returns></returns>

    public float BMI()
    {
        //BMI公式
        float result = weight / ((height / 100) * (height / 100));
        //回傳結果
        return result;

    }

    //參數語法 : 類型 名稱 指定 預設值
    //有預設值的參數稱為[選填式參數] - 可以不填、值為預設值
    //選填式參數必須定義在最右邊

        /// <summary>
        /// 走路方法
        /// </summary>
        /// <param name="speed"></param>
        /// <param name="direction"></param>


    public void Walk(int speed , string direction = "前方" , string sound = "咖咖咖")
    {
        print("用時速:" + speed + "公里走路");
        print("走路音效" + sound);
        print("走路方向 : " + direction);

    }


    //攻擊方法 : 徒手
    public void AttackWithHand()
    {

    }
    //攻擊方法 : 拿武器攻擊，音效
    public void AttackWithWeapon()
    {

    }
      
    //多載 Overload
    //1. 相同名稱方法
    //2. 參數數量不同 或 參數類型不同

    /// <summary>
    /// 徒手攻擊
    /// </summary>
    public void Attack ()
    {
        print(gameObject.name + "徒手攻擊");
    }

    /// <summary>
    /// 武器攻擊
    /// </summary>
    /// <param name="weapon">想要使用的武器</param>
    public void Attack(string weapon)
    {
        print(gameObject.name + "用武器攻擊" + weapon + "攻擊");
        print("武器音效");
    }

    //讓unity按鈕Button使用方法條件 :
    //1. 修飾詞為公開 public
    //2. 參數數量小於等於1

    /// <summary>
    /// 技能
    /// </summary>
    public void Skill()
    {
        print(gameObject.name + "施放技能");
    }

}
