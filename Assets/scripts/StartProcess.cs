using UnityEngine;
using System;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using Unity.VisualScripting;


public class StartProcess : MonoBehaviour
{
    string[] _groupLists = { "MiniGame", "NovelGame", "Site" };
    List<GameData> _MiniGame =  new List<GameData>();
    List<GameData> _NovelGame = new List<GameData>();
    List<GameData> _Site = new List<GameData> { };

    List<LoadingData> _loadingDatas = new List<LoadingData>();

    async void Start()
    {
        GameData[] _gameDatas = new GameLists()._gameDatas.ToArray();
        foreach(GameData i in _gameDatas)
        {
            if(i._groupName == _groupLists[0])
            {
                _MiniGame.Add(i);
            }
            else if(i._groupName == _groupLists[1])
            {
                _NovelGame.Add(i);
            }
            else if(i._groupName == _groupLists[2])
            {
                _Site.Add(i);
            }
        }
        //グループごとにLoadingDataクラスをインスタンスして保存
        if(_MiniGame.Count != 0)
        {
            LoadingData _loadingData = new LoadingData();
            await _loadingData._firstLoading("MiniGame",_MiniGame.ToArray());
            _loadingDatas.Add(_loadingData);
        }
        if(_NovelGame.Count != 0)
        {
            LoadingData _loadingData = new LoadingData();
            await _loadingData._firstLoading("_NovelGame", _NovelGame.ToArray());
            _loadingDatas.Add(_loadingData);
        }
        if(_Site.Count != 0)
        {
            LoadingData _loadingData = new LoadingData();
            await _loadingData._firstLoading("Site", _Site.ToArray());
            _loadingDatas.Add(_loadingData);
        }
    }


}
