/****************************************************
    文件：AirBossBaseRigidityState.cs
	功能：Nothing
*****************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class AirBossBaseRigidityState<T, X> : AirEnemyBaseRigidityState<T, X> where T : EnemyBase<X> where X : AirEnemyBaseData
{
    public AirBossBaseRigidityState(FiniteStateMachine fsm, string animBoolName, T ower, X data) : base(fsm, animBoolName, ower, data)
    {

    }
}