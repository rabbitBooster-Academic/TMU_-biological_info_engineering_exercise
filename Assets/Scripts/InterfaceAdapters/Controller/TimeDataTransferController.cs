using System;
using UniRx;

public class TimeDataTransferController : ITimeDataTransferController
{
    public TimeDataTransferController(IDeltaTimeTransferInput deltaTimeTransferView)
    {
        DeltaTimeAsObservable = deltaTimeTransferView.DeltaTimeAsObservable.Select(vm=>vm.DeltaTime);
    }

    public IObservable<float> DeltaTimeAsObservable { get; }

}
