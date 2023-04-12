/****************************************************
    文件：NoRecycleBullet.cs
	功能: 不回收子弹基类
*****************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class NoRecycleBulletBase<T> : BulletBase<T> where T : BulletBaseData
{
    protected override void StopBullet()
    {
        _isOver = true;
        _move.ResetGravityScale();//还原重力的大小的影响
        _move.SetXVelocity(0);
        AddTorque(_data.torqueValue);
        Core.Get<BulletCombatComponent>().SetActive(false);
        DestroyInConstTime();
    }
}