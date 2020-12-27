using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageManeger : MonoBehaviour
{
    [SerializeField] private List<GameObject> levelBlockList = new List<GameObject>();

    void Awake()
    {
        Init();
        if (levelBlockList.Count < LevelManeger.Instance.levelNumber)
        {
            Debug.LogError("そのレベルは存在しません");
        }
        else
        {
            levelBlockList[LevelManeger.Instance.levelNumber].SetActive(true);
        }
    }


    public void Init()
    {
        for (int i = 0; i< levelBlockList.Count; i++)
        {
            levelBlockList[i].SetActive(false);
        }
    }
}
