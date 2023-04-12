/****************************************************
    文件：BossBaseDeadState.cs
	功能：Nothing
*****************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BossBaseDeadState<T, X> : EnemyBaseDeadState<T, X> where T : EnemyBase<X> where X : EnemyBaseData
{
    public BossBaseDeadState(FiniteStateMachine fsm, string animBoolName, T ower, X data) : base(fsm, animBoolName, ower, data)
    {

    }
}