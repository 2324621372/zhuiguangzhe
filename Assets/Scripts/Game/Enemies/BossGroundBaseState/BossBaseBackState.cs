/****************************************************
    文件：BossBaseBackState.cs
	功能：Nothing
*****************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BossBaseBackState<T, X> : EnemyBaseBackState<T, X> where T : EnemyBase<X> where X : EnemyBaseData
{
    public BossBaseBackState(FiniteStateMachine fsm, string animBoolName, T ower, X data) : base(fsm, animBoolName, ower, data)
    {

    }
}