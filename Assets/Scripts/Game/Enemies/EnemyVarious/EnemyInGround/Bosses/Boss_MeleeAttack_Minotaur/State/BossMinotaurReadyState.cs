/****************************************************
    文件：BossMinotaurReadyState.cs
	功能：Nothing
*****************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BossMinotaurReadyState : BossBaseReadyState<Boss_MeleeAttack_Minotaur, BossMinotaurData>
{
    private string _audioClipName = "enemy_minotaur_ready";
    public BossMinotaurReadyState(FiniteStateMachine fsm, string animBoolName, Boss_MeleeAttack_Minotaur ower, BossMinotaurData data) : base(fsm, animBoolName, ower, data)
    {
        AddTargetState(()=>AnimFinish,E_CharacterState.MELEEATTACKTWO);
    }
    public override void Enter()
    {
        base.Enter();
        Behavior.SetDomineering(true);
        AudioMgr.Instance.PlayOnce(_audioClipName);

    }
    public override void Exit()
    {
        base.Exit();
        Behavior.SetDomineering(false);
    }
}