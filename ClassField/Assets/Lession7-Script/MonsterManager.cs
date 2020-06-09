using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterManager : MonoBehaviour
{

    public GameObject[] monsters;

    public void CreatMonster(int index)
    {
        Instantiate(monsters[index], new Vector3(1.43f, -1.36f, 0), Quaternion.identity);
    }
}
