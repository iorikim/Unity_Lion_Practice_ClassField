using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    /// <summary>
    /// 學習模式
    /// </summary>
    [Header("怪物一號")]
    public Enemy monster1;

    [Header("怪物二號")]
    public Enemy monster2;

    private void Start()
    {
        print("怪物一號的魔力:"+ monster1.MP);
        print("怪物二號的裝備:" + monster2.裝備名稱);

        monster1.HP = 100;
        monster2.HP = 300;
        monster1.GUARD = 50;
        monster1.arms = "木棍";
        monster2.arms = "短刀";
        monster1.Key = true;
        monster2.treasure = true;

        
    }
}
