/****************************************************
    文件：GetItemState.cs
	功能：主角拾取物品状态
*****************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GetItemState : AbilityBaseState
{
    public GetItemState(FiniteStateMachine fsm, string animBoolName, HeroMan ower, HeroManData data) : base(fsm, animBoolName, ower, data)
    {


    }
    public override void Enter()
    {
        base.Enter();
        Move.SetXVelocity(0);
    }
    public override void AnimatorFinishTrigger()
    {
        base.AnimatorFinishTrigger();
        SetAbilityDown();
    }
    public override E_CharacterState TargetState()
        => E_CharacterState.IDLE;
}