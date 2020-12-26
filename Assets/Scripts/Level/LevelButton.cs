using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;

public class LevelButton : MonoBehaviour
{
    public int level;
    private Button levelbutton;

    // Start is called before the first frame update
    void Awake()
    {
        levelbutton = GetComponent<Button>();
        levelbutton.OnClickAsObservable()
            .Subscribe(_ =>
            {
                LevelManeger.Instance.SelectLevel(level);
                SoundManager.Instance.PlaySe("NormalButton");
            }) ;
    }
}
