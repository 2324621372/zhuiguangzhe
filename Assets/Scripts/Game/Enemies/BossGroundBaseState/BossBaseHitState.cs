/****************************************************
    文件：BossBaseHitState.cs
	功能：Nothing
*****************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BossBaseHitState<T, X> : EnemyBaseHitState<T, X> where T : EnemyBase<X> where X : EnemyBaseData
{
    public BossBaseHitState(FiniteStateMachine fsm, string animBoolName, T ower, X data) : base(fsm, animBoolName, ower, data)
    {

    }
}