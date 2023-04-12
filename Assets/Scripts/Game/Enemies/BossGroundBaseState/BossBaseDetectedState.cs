/****************************************************
    文件：BossBaseDetectedState.cs
	功能：Nothing
*****************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BossBaseDetectedState<T, X> : EnemyBaseDetectedState<T, X> where T : EnemyBase<X> where X : EnemyBaseData
{
    protected bool _isGrounded;
    public BossBaseDetectedState(FiniteStateMachine fsm, string animBoolName, T ower, X data) : base(fsm, animBoolName, ower, data)
    {

    }
    public override void Check()
    {
        base.Check();
        _isGrounded = ColliderCheck.Ground;
    }
}