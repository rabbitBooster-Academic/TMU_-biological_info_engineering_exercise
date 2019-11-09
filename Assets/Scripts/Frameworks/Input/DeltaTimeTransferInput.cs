using System;
using UniRx;
using UnityEngine;
using Zenject;

public class DeltaTimeTransferInput : IDeltaTimeTransferInput,ITickable
{

    public IObservable<DeltaTimeTransferViewModel> DeltaTimeAsObservable => deltaTimeAsObservable;
    public Subject<DeltaTimeTransferViewModel> deltaTimeAsObservable = new Subject<DeltaTimeTransferViewModel>();

    public void Tick()
    {
        deltaTimeAsObservable.OnNext(new DeltaTimeTransferViewModel(Time.deltaTime));
    }
}
