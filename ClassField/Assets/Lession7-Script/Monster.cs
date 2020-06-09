using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Monster : MonoBehaviour
{
    [Header("移動速度"), Range(0,100)]
    public float speed;
    
    [Header("傷害值"), Range(10,500)]
    public float damage;

    public GameObject explosion;


    /// <summary>
    /// 移動
    /// </summary>
    protected void Move()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);

    }

    /// <summary>
    /// 爆炸
    /// </summary>
    protected  void Explosion()
    {
        //生成爆炸效果
        GameObject exp = Instantiate(explosion, transform.position, Quaternion.identity);
        Destroy(gameObject);        //刪除怪物
        Destroy(exp, 2.5f);             //2.5秒後刪除爆炸效果
    }

    protected virtual void Update()
    {
        Move();
    }

    private void Awake()
    {
        Physics2D.GetIgnoreLayerCollision(8, 8);        //忽略Layer碰撞
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name=="house")
        {
            Debug.Log("+D");
            collision.gameObject.GetComponent<House>().Damage(damage);
            Debug.Log("-D");
            Explosion();
        }
    }

}
