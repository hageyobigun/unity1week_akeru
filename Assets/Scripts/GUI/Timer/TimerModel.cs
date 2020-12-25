using System.Collections;
using UnityEngine;
using UniRx;
using System;

public class TimerModel
{
    public ReactiveProperty<int> count;


    public TimerModel(int CountTime)
    {
        count = new ReactiveProperty<int>(CountTime);
    }

    public IEnumerator TimerCount(int CountTime)
    {
        count.Value = CountTime;
        while (count.Value > 0)
        {
            count.Value--;
            yield return new WaitForSeconds(1);
        }
    }

}
