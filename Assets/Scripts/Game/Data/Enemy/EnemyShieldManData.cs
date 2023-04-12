/****************************************************
    文件：EnemyShieldManData.cs
	功能：ShieldMan敌人数据
*****************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;
[CreateAssetMenu(fileName = "newEnemyShieldData", menuName = "数据/敌人/EnemyShieldData")]
public class EnemyShieldManData : EnemyBaseData
{
    [FoldoutGroup("@HitStateProperty"), LabelWidth(200), GUIColor(0.1f, 1f, 0.1f), Range(0, 100)]
    public int hitToShieldStateProperty = 50;//进入举盾状态的概率
}