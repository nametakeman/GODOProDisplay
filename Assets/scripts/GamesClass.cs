using UnityEngine;
using System;
using System.Collections.Generic;


class GameLists : MonoBehaviour 
{
    public List<GameData> _gameDatas = new List<GameData>() { new test1(), new test2(), new test3() };
}


public interface GameData
{
    //実行ファイルのディレクトリ
    string _direcExe { get; set; }
    //ゲーム名
    string _gameName { get; set; }
    //製作者名
    string _dev { get; set; }
    //班名
    string _groupName { get; set; }
}

public class test1 : GameData
{
    public string _direcExe { get; set; } = "test1Dire";
    public string _gameName { get; set; } = "test1Name";
    public string _dev { get; set; } = "俺";
    public string _groupName { get; set; } = "_groupName1";
}

public class test2 : GameData
{
    public string _direcExe { get; set; } = "test2Dire";
    public string _gameName { get; set; } = "test2Name";
    public string _dev { get; set; } = "俺";
    public string _groupName { get; set; } = "_groupName2";
}

public class test3 : GameData
{
    public string _direcExe { get; set; } = "test3Dire";
    public string _gameName { get; set; } = "test3Name";
    public string _dev { get; set; } = "俺";
    public string _groupName { get; set; } = "_groupName3";
}