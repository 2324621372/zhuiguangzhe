/****************************************************
    文件：BombBehaviorComponent.cs
	功能：Nothing
*****************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BombBehaviorComponent : BehaviorBaseComponent,IBombBehavior
{
    public override void Damage(Vector3 attackPos, float damageValue, E_Attack type = E_Attack.NONE)
    {
        Dead();
    }
    public override void Dead()
    {
        SubEventMgr.ExecuteEvent(E_EventName.BOMB_EXLPOSTION);
    }
    public void RecoverHealth()
        => _curHelath = _maxHealth;
    public void SetGroup(E_Group selfGroup)
        => _group = selfGroup;
}
  