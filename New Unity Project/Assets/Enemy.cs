using UnityEngine;

public class Enemy : MonoBehaviour
{
    /// <summary>
    /// 怪物的血量
    /// </summary>
    [Header("血量"), Range(50, 500)]
    [Tooltip("怪物的血量")]
    public int HP = 250;

    /// <summary>
    /// 怪物的魔力
    /// </summary>
    [Header("魔力"), Range(10, 100)]
    [Tooltip("怪物的魔力")]
    public int MP = 100;

    /// <summary>
    /// 怪物的移動速度
    /// </summary>
    [Header("Monster Speed"), Range(1, 50.5f)]
    [Tooltip("怪物的移動速度")]
    public float SPEED = 10.5f;

    /// <summary>
    /// 怪物的攻擊力
    /// </summary>
    [Header("Monster Attack"), Range(20, 200)]
    [Tooltip("怪物的攻擊力")]
    public int ATTACK = 50;

    /// <summary>
    /// 怪物的防禦力
    /// </summary>
    [Header("Monster Guard"), Range(0, 100)]
    [Tooltip("怪物的防禦力")]
    public int GUARD;

    /// <summary>
    /// 裝備
    /// </summary>
    [Header("EQUIPMENT")]
    [Tooltip("裝備")]
    public string arms;

    /// <summary>
    /// 是否有帶鑰匙
    /// </summary>
    [Header("其他資料")]
    [Tooltip("是否帶有鑰匙")]
    public bool Key = false;
    
}
