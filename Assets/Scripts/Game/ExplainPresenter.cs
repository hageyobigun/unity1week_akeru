using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ExplainPresenter : MonoBehaviour
{
    [SerializeField] private GameObject examplainImage = null;
    [SerializeField] private Button playButton = null;

    void Awake()
    {
        examplainImage.SetActive(false);

        playButton.OnClickAsObservable()
            .Subscribe(_ =>
            {
                SceneManager.LoadScene("Play");
                SoundManager.Instance.PlaySe("NormalButton");
            });
    }

    public void SetExplain()
    {
        examplainImage.SetActive(true);
    }

}
