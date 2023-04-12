/****************************************************
    文件：IBombBase.cs
	功能：Nothing
*****************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public interface IBombBase  
{
    void Init(Vector3 pos, Vector2 dir, E_Group selfGroup, HashSet<E_Group> hostilityGroup);
}