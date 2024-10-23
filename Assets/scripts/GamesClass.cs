using UnityEngine;
using System;
using System.Collections.Generic;


class GameLists : MonoBehaviour 
{
    public List<GameData> _gameDatas = new List<GameData>() { new test1(), new test2(), new test3() };
}


public interface GameData
{
    //���s�t�@�C���̃f�B���N�g��
    string _direcExe { get; set; }
    //�Q�[����
    string _gameName { get; set; }
    //����Җ�
    string _dev { get; set; }
    //�ǖ�
    string _groupName { get; set; }
}

public class test1 : GameData
{
    public string _direcExe { get; set; } = "test1Dire";
    public string _gameName { get; set; } = "test1Name";
    public string _dev { get; set; } = "��";
    public string _groupName { get; set; } = "_groupName1";
}

public class test2 : GameData
{
    public string _direcExe { get; set; } = "test2Dire";
    public string _gameName { get; set; } = "test2Name";
    public string _dev { get; set; } = "��";
    public string _groupName { get; set; } = "_groupName2";
}

public class test3 : GameData
{
    public string _direcExe { get; set; } = "test3Dire";
    public string _gameName { get; set; } = "test3Name";
    public string _dev { get; set; } = "��";
    public string _groupName { get; set; } = "_groupName3";
}