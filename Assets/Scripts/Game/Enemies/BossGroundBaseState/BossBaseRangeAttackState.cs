/****************************************************
    文件：BossBaseRangeAttackState.cs
	功能：Nothing
*****************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BossBaseRangeAttackState<T, X> : EnemyBaseRangeAttackState<T, X> where T : EnemyBase<X> where X : EnemyBaseData
{
    public BossBaseRangeAttackState(FiniteStateMachine fsm, string animBoolName, T ower, X data) : base(fsm, animBoolName, ower, data)
    {

    }
}