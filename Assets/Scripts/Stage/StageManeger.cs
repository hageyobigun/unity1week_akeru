using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageManeger : MonoBehaviour
{
    [SerializeField] private SpriteRenderer waku = null;
    [SerializeField] private List<Sprite> wakuList = new List<Sprite>();

    void Awake()
    {
        if (wakuList.Count < LevelManeger.Instance.levelNumber)
        {
            Debug.LogError("そのレベルは存在しません");
        }
        else
        {
            waku.sprite = wakuList[LevelManeger.Instance.levelNumber];
        }
    }
}
