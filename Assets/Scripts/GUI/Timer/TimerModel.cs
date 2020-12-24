using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;

public class TimerModel
{
    public ReactiveProperty<int> count;


    public TimerModel()
    {
        count = new ReactiveProperty<int>();
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
