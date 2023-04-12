/****************************************************
    文件：IReader.cs
	功能：数据读取接口
*****************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public interface IReader
{
    void SaveData(object data, string fileName);
    T LoadData<T>(string fileName) where T:class,new();
}