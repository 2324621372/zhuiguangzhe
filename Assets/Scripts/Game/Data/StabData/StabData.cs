/****************************************************
    文件：StabData.cs
	功能：地刺数据类
*****************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;
[CreateAssetMenu(fileName = "newStabData", menuName = "数据/StabData/StabData")]
[InlineEditor]
public class StabData : ScriptableObject
{
    public Sprite bloodSprire;//带血的Sprite
}