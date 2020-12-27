using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManeger : SingletonMonoBehaviour<LevelManeger>
{
    [SerializeField] private ExplainPresenter explainPresenter = null;
    private bool isFirst;
    private int level;
    public int levelNumber{get {return this.level;}} //取得用

    void Start()
    {
        isFirst = true;
        level = 0;
        DontDestroyOnLoad(this.gameObject);
    }


    public void SelectLevel(int _level)
    {
        level = _level - 1;
        if (isFirst)
        {
            isFirst = false;
            explainPresenter.SetExplain();
        }
        else
        {
            SceneManager.LoadScene("Play");
        }
    }
}
