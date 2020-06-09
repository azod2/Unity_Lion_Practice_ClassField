using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Class6_APIPratice : MonoBehaviour
{
    private Rigidbody rb;
    private float time;
    public GameObject sphere;
    public Renderer pic;



    // Start is called before the first frame update
    void Start()
    {
        //練習1
        time = Time.timeScale=2.0f;

        //練習2
        pic.GetComponent<SpriteRenderer>().flipX = true;

        //練習3
        print(Mathf.Floor(1.23456f));

        //練習4
        rb = sphere.GetComponent<Rigidbody>();
       rb.AddForce (Vector3.one * 1000.0f);          
    }


    // Update is called once per frame
    void Update()
    {

    }
}
