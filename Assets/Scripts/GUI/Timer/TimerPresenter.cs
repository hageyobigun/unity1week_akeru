using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class TimerPresenter : MonoBehaviour
{
    [SerializeField] private int startTimeValue = 60;
    [SerializeField] private TimerView timerView = null;
    private TimerModel timerModel;

    private void Awake()
    {
        timerModel = new TimerModel();

        timerModel.count
            .Subscribe(count => timerView.SetTimer(count));

        StartTimer();
    }


    public void StartTimer()
    {
        StartCoroutine(timerModel.TimerCount(startTimeValue));
    }

}
