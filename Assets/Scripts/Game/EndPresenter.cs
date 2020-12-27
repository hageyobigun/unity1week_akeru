using UnityEngine;
using UniRx;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class EndPresenter : MonoBehaviour
{
    [SerializeField] private EndView endView = null;
    [SerializeField] private Button retryButton = null;
    [SerializeField] private Button menuButton = null;

    public void Awake()
    {
        retryButton.OnClickAsObservable()
          .Subscribe(_ =>
          {
              SceneManager.LoadScene("Play");
              SoundManager.Instance.PlaySe("NormalButton");
          });

        menuButton.OnClickAsObservable()
            .Subscribe(_ =>
            {
                SceneManager.LoadScene("Menu");
                SoundManager.Instance.PlaySe("NormalButton");
            });

        endView.OffEndText();
        endView.OFFEndImage();
    }


    public IEnumerator EndGame()
    {
        endView.SetEndText("FINISH!");
        yield return new WaitForSeconds(1);
        endView.OffEndText();
        endView.SetEndImage();
    }

}
