/****************************************************
    文件：StartScenePlayerController.cs
	功能：开始场景中Player移动控制
*****************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class StartScenePlayerController : MonoBehaviour 
{
    private float _forwardSpeed=3;
    private float _backSpeed=-2;
    private float _curSpeed;
    public bool IsForward { get; private set; }
    public void Init()
    {
        IsForward = true;
        _curSpeed = _forwardSpeed;
    }
    public void UpdatePlayerMove()
    {
        if (_curSpeed == 0f)
        {
            Debug.LogError("当前Player速度未初始化");
            return;
        }
        CheckIsChangeDir();
        Move();
    }
    private void CheckIsChangeDir()
    {
        if(IsForward&&transform.position.x>=ScreenPosUtil.GetScreenMaxPos().x)
        {
            IsForward = false;
            _curSpeed = _backSpeed;
        }
        else if(!IsForward && transform.position.x <= ScreenPosUtil.GetScreenMinPos().x)
        {

            IsForward = true;
            _curSpeed = _forwardSpeed;
        }
    }
    private void Move()
        => transform.Translate(new Vector3(_curSpeed * Time.deltaTime, 0, 0));
}