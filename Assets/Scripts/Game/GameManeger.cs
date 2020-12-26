using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class GameManeger : MonoBehaviour
{
    [SerializeField] private StartPresenter startPresenter = null;
    [SerializeField] private EndPresenter endPresenter = null;
    [SerializeField] private TimerPresenter timerPresenter = null;
    [SerializeField] private PlayerController playerController = null;

    void Awake()
    {
        StartGame();
        timerPresenter.EndTimer
            .Where(end => end == true)
            .Subscribe(_ => EndGame());
    }

    public void StartGame()
    {
        playerController.StopPlayer();
        //game start
        Observable.FromCoroutine(() => startPresenter.StartGame())
            .Subscribe(_ =>
            {
                playerController.StartPlayer();
                timerPresenter.StartTimer(); //タイマー起動
            })
            .AddTo(this);
    }


    public void EndGame()
    {
        playerController.StopPlayer();
        endPresenter.EndGame();
    }

}
