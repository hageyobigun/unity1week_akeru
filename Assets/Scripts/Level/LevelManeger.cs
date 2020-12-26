using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManeger : SingletonMonoBehaviour<LevelManeger>
{
    private int level;
    public int levelNumber{get {return this.level;}} //取得用

    void Start()
    {
        level = 0;
        DontDestroyOnLoad(this.gameObject);
    }


    public void SelectLevel(int _level)
    {
        level = _level - 1;
        SceneManager.LoadScene("Play");
    }
}
