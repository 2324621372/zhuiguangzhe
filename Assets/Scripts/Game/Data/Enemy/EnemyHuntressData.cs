/****************************************************
    文件：EnemyHuntreeData.cs
	功能：女猎人数据
*****************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;
[CreateAssetMenu(fileName = "newEnemyHuntressData", menuName = "数据/敌人/EnemyHuntressData")]
public class EnemyHuntressData:EnemyBaseData
{
    [FoldoutGroup("@MeleeAttackStateProperty/MeleeAttackTwo"), LabelWidth(200), GUIColor(0.1f, 1f, 0.1f)]
    public int meleeAttackTwoCombatIndex=3;
}