/****************************************************
    文件：AirBossDemonDashTwoState.cs
	功能：Nothing
*****************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class AirBossDemonMeleeAttackTwoState : AirBossBaseMeleeAttackState<AirBoss_RangeAttack_Demon, AirBossDemonData>
{
    private string _audioClipName = "enemy_demon_meleeAttack";
    public AirBossDemonMeleeAttackTwoState(FiniteStateMachine fsm, string animBoolName, AirBoss_RangeAttack_Demon ower, AirBossDemonData data) : base(fsm, animBoolName, ower, data)
    {
        AddTargetState(() => !_isAbilityDown, E_CharacterState.DISAPPEAR);
    }
    public override void Enter()
    {
        base.Enter();
        AudioMgr.Instance.PlayOnce(_audioClipName);
    }
    public override void ActionUpdate()
    {
        base.ActionUpdate();
        Move.LookAtPlayer();
        Move.SetXVelocityInFacing(_data.meleeAttackTwoVelocity,true);
    }
}