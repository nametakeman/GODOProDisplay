using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using Unity.VisualScripting;
public class LoadingData : MonoBehaviour
{
    string _groupOb;
    string _devName;
    string _gameTitle;

    int _nowPage = 0;
    string _groupName = "";
    GameData[] _gameDatas;

    public async UniTask _firstLoading(string _name, GameData[] _datas)
    {
        _gameDatas = _datas;
        _groupName = _name;
        await loadingData(0);
    }

    public async UniTask loadingData(int pageNum)
    {
        GameData _targetGame = _gameDatas[pageNum];
        _groupOb = _targetGame._groupName;
        _gameTitle = _targetGame._gameName;
        _devName = _targetGame._dev;
    }

    public void _plussPage()
    {
        _nowPage++;
        if(_nowPage == _gameDatas.Length)
        {
            _nowPage = 0;
        }
        loadingData(_nowPage);
    }
    public void _minusPage()
    {
        _nowPage--;
        if(_nowPage == -1)
        {
            _nowPage = _gameDatas.Length - 1;
        }

        loadingData(_nowPage);
    }
}

