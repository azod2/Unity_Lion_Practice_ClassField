using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{

    public float length,width,height;

    /// <summary>
    /// protected 保護: 只允許子類別存取
    /// </summary>
    protected float volume;


    /// <summary>
    /// 取得體積
    /// virtual 虛擬 : 允許子類別覆寫
    /// </summary>
    /// <returns></returns>
    public virtual float GetVolume()
    {
        volume = length * width * height;
        return length * width * height;
    }

}
