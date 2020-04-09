using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    
    [Header("血量"), Tooltip("怪物的血量"), Range(50, 500)]
    public int hp;

    [Header("魔力"), Tooltip("怪物的魔力"), Range(10, 100)]
    public int mp = 100;

    [Header("能力值"), Range(1, 50.5f)]
    public float sep = 10.5f;

    [Range(20, 200)]
    public int atk = 50;

    [Range(0, 100)]
    public int def;

    [Header("裝備")]
    public string weapon;

    public string armor = "皮衣";

    [Header("其他資料"), Tooltip("怪物是否帶有鑰匙")]
    public bool key = false;

    [Tooltip("怪物是否帶有寶物")]
    public bool money = false;
    }   


