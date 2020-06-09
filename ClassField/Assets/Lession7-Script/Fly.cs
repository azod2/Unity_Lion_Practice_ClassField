using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : Monster
{
    [Header("飛行範圍"),Range(1,30)]
    public float range;

    private void FlyAway()
    {
        //Time.timeSinceLevelLoad 從場景載入開始計時
        //Mathf.Sin 曲線
        transform.Translate(0, range*Time.deltaTime*Mathf.Sin(Time.timeSinceLevelLoad*5), 0);
    }

    protected override void Update()
    {
        base.Update();
        FlyAway();
    }

}
