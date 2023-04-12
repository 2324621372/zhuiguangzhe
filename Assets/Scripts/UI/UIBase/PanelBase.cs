/****************************************************
    文件：PanelBase.cs
	功能：UI面板基类
*****************************************************/
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public abstract class PanelBase : UIElement,IPanelBase
{
    public override void Init()
    {
        base.Init();
        InitRefreshAction();
    }
    private void PlayButtonMusic()
        => AudioMgr.Instance.PlayUIMusic(E_UIMusic.NormalClick);
    private void PlayeToggleMusic(bool value)
        => AudioMgr.Instance.PlayUIMusic(E_UIMusic.ToggleClick);
    private void ToggleRefresh(bool value)
        => Refresh();
    public void InitRefreshAction()
    {
        //给所有button添加刷新事件
        foreach (var btn in transform.GetComponentsInChildren<Button>())
        {
            //防止重复添加
            btn.onClick.RemoveListener(Refresh);
            btn.onClick.AddListener(Refresh);
            btn.onClick.RemoveListener(PlayButtonMusic);
            btn.onClick.AddListener(PlayButtonMusic);
        }
        //给所有Toggle添加刷新事件
        foreach (var tgl in transform.GetComponentsInChildren<Toggle>())
        {
            tgl.onValueChanged.RemoveListener(ToggleRefresh);
            tgl.onValueChanged.AddListener(ToggleRefresh);
            tgl.onValueChanged.RemoveListener(PlayeToggleMusic);
            tgl.onValueChanged.AddListener(PlayeToggleMusic);
        }
    }
    public void ChangeButtonMusic(Button btn,E_UIMusic type)
    {
        btn.onClick.RemoveListener(PlayButtonMusic);
        btn.onClick.AddListener(()=>AudioMgr.Instance.PlayUIMusic(type));
    }
    public void ChangeToggleMusic(Toggle tgl,E_UIMusic type)
    {
        tgl.onValueChanged.RemoveListener(PlayeToggleMusic);
        tgl.onValueChanged.AddListener((value) => AudioMgr.Instance.PlayUIMusic(type));
    }
}