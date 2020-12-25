using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class TimerPresenter : MonoBehaviour
{
    [SerializeField] private int startTimeCount = 60;
    [SerializeField] private TimerView timerView = null;
    
    private TimerModel timerModel;

    private ReactiveProperty<bool> endTimer = new ReactiveProperty<bool>();
    public IReadOnlyReactiveProperty<bool> EndTimer { get { return endTimer; }}

    private void Awake()
    {
        timerModel = new TimerModel(startTimeCount);

        timerModel.count
            .Subscribe(count => timerView.SetTimer(count));
    }


    public void StartTimer()
    {
        endTimer.Value = false; //timer終わったらtrueにする
        Observable.FromCoroutine(() => timerModel.TimerCount(startTimeCount))
            .Subscribe(_ => endTimer.Value = true)
            .AddTo(this);
    }

}
