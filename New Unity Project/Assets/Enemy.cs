using UnityEngine;

public class Enemy: MonoBehaviour
{
    /// <summary>
    /// 怪物的血量
    /// </summary>
    [Header("怪物的血量"), Range(50, 500)]
    public int HP = 250;

    /// <summary>
    /// 怪物的魔力
    /// </summary>
    [Header("怪物的魔力"), Range(10, 100)]
    public int MP = 100;

    /// <summary>
    /// 怪物的移動速度
    /// </summary>
    [Header("怪物的移動速度"), Range(1, 50.5f)]
    public float SPEED = 10.5f;

    /// <summary>
    /// 怪物的攻擊力
    /// </summary>
    [Header("怪物的攻擊力"), Range(20, 200)]
    public int ATTACK = 50;

    /// <summary>
    /// 怪物的防禦力
    /// </summary>
    [Header("怪物的防禦力"), Range(0, 100)]
    public int GUARD ;











}
