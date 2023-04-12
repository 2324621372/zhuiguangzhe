/****************************************************
    文件：AboutPanel.cs
	功能: 游戏制作信息介绍
*****************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class AboutPanel : PanelBase
{
    private float _showTextTime = 4f;
    private string[] _contents = new string[4]
        {
            "程序：".SetColor(E_TextColor.Red)+"肖\n",
            "美术：".SetColor(E_TextColor.Blue)+"肖\n",
            "音乐：".SetColor(E_TextColor.Green)+"肖\n",
            "策划：".SetColor(E_TextColor.Yellow)+"肖\n",
        };
    private string _content;
    public override void InitChild()
    {
        for (int i = 0; i < _contents.Length; i++)
            _content += _contents[i];
        GetControl<Button>("btn_Quit").onClick.AddListener(() => UIManager.Instance.BackPanel());
        GetControl<Text>("txt_Msg").SetText("");
    }
    private void Start()
    {
        ConvertButtonMusic("btn_Quit", E_UIMusic.NotClick);
    }
    public override void Show()
    {
        base.Show();
        GetControl<Text>("txt_Msg").DOKill();
        GetControl<Text>("txt_Msg").SetText("");
        GetControl<Text>("txt_Msg").DOText(_content, _showTextTime).SetEase(Ease.Linear);
    }
}