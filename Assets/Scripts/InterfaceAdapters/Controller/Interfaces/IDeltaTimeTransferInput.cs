using System;

public interface IDeltaTimeTransferInput
{
    IObservable<DeltaTimeTransferViewModel> DeltaTimeAsObservable { get; }
}
