/****************************************************
    文件：AirBossBaseDisappearState.cs
	功能：Nothing
*****************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public abstract class AirBossBaseDisappearState<T, X> : AirEnemyBaseDisappearState<T, X> where T : EnemyBase<X> where X : AirEnemyBaseData
{
    public AirBossBaseDisappearState(FiniteStateMachine fsm, string animBoolName, T ower, X data) : base(fsm, animBoolName, ower, data)
    {

    }
}