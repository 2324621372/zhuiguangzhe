/****************************************************
    文件：BossBaseMeleeAttackState.cs
	功能：Nothing
*****************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BossBaseMeleeAttackState<T, X> : EnemyBaseMeleeAttackState<T, X> where T : EnemyBase<X> where X : EnemyBaseData
{
    public BossBaseMeleeAttackState(FiniteStateMachine fsm, string animBoolName, T ower, X data) : base(fsm, animBoolName, ower, data)
    {

    }
}