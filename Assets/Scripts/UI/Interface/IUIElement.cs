/****************************************************
    文件：IUIElement.cs
	功能：基础UI集合接口
*****************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public interface IUIElement :IUIInit,IUIShow,IUIHide,IUIRefresh
{
    Transform GetTrans();
    void Reacquire();//再次获取子类身上的接口
}