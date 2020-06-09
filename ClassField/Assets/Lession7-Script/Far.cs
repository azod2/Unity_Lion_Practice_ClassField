using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Far : Ground
{

    [Header("停止距離"),Range(0,10)]
    public float stopDistance;
    [Header("投擲物件")]
    public GameObject prop;
    [Header("目標物件"), Range(0, 10)]
    private Transform target;
    [Header("投擲間隔時間"), Range(0, 10)]
    public float cd;
    [Header("計數器"), Range(0, 10)]
    public float timer;
    [Header("停止時間"), Range(0, 10)]
    public float deadtimes;

    /// <summary>
    /// 繪製圖示事件 : 右
    /// </summary>
    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        Gizmos.DrawLine(transform.position, transform.position+transform.right * stopDistance);
    }

    private void Start()
    {
        target = GameObject.Find("house").transform;
    }
    protected override void Update()
    {
        base.Update();
        Throw();
    }

    private void Throw()
    {
        float dis =  Vector3.Distance(transform.position, target.position);
        if (dis <= stopDistance)
	    {
            speed = 0;            
            timer += Time.deltaTime;

            if (timer>=cd)
            {
            timer = 0;
            GameObject temp = Instantiate(prop, transform.position + transform.right/3 + transform.up/3, Quaternion.identity);
            float a, b;
            a = Random.Range(100, 200);
            b = Random.Range(100, 200);
            temp.GetComponent<Rigidbody2D>().AddForce(new Vector2(a, b));
                temp.GetComponent<ThrowObject>().damage = damage;
            }
	    }
            Invoke("Explosion", deadtimes);
    }




}
