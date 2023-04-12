/****************************************************
    文件：AirBossBaseAppearState.cs
	功能：Nothing
*****************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class AirBossBaseAppearState<T, X> : AirEnemyBaseAppearState<T, X> where T : EnemyBase<X> where X : AirEnemyBaseData
{
    public AirBossBaseAppearState(FiniteStateMachine fsm, string animBoolName, T ower, X data) : base(fsm, animBoolName, ower, data)
    {

    }
}