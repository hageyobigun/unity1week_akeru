using UnityEngine;
using UniRx;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndPresenter : MonoBehaviour
{
    [SerializeField] private EndView endView = null;
    [SerializeField] private Button retryButton = null;
    [SerializeField] private Button menuButton = null;

    public void Awake()
    {
        retryButton.OnClickAsObservable()
          .Subscribe(_ => SceneManager.LoadScene("Play"));

        menuButton.OnClickAsObservable()
            .Subscribe(_ => SceneManager.LoadScene("Menu"));

        endView.OffEndText();
    }


    public void EndGame()
    {
        endView.SetEndText("FINISH!");
    }

}
