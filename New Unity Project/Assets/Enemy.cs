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
    [Header("能力值"), Range(1.0f, 50.5f)]
    public float SPEED = 10.5f;

    /// <summary>
    /// 怪物的攻擊力
    /// </summary>
    [Range(20, 200)]
    public int ATTACK = 50;

    /// <summary>
    /// 怪物的防禦力
    /// </summary>
    [Range(0, 100)]
    [Tooltip("怪物的防禦力")]
    public int GUARD;

    /// <summary>
    /// 武器名稱
    /// </summary>
    [Header("裝備")]
    public string arms;

    /// <summary>
    /// 裝備名稱
    /// </summary>
    public string 裝備名稱 = "皮衣";

    /// <summary>
    /// 是否有帶鑰匙
    /// </summary>
    [Header("其他資料")]
    [Tooltip("怪物是否帶有鑰匙")]
    public bool Key = false;

    [Tooltip("怪物是否帶有寶物")]
    public bool treasure = false;


}
