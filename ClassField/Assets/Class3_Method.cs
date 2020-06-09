using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Class3_Method : MonoBehaviour
{

    public Person person1;
    public Person person2;

    // Start is called before the first frame update
    void Start()
    {
        //呼叫 person1 方法 talk
        person1.Talk();
        person2.Talk();

        print("警察:"+ person1.BMI());
        print("小孩:"+ person2.BMI());

        person1.Walk(30 , sound : "嘎嘎 嘎");
        person2.Walk(70);

        person1.Attack("槍");
        person2.Attack();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
