/****************************************************
    文件：ITask.cs
	功能：任务接口
*****************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public interface ITaskInit
{
    void Init(Action callback);
}