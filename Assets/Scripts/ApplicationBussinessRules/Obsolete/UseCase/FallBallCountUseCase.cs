
using System;
using UniRx;

public class FallBallCountUseCase : IFallBallCountUseCase
{
    FallCounterEntity fallCounterEntity = new FallCounterEntity();

    public IObservable<BallFallAmountOutputData> BallCountAsObserable => ballCountAsObserable;
    public BehaviorSubject<BallFallAmountOutputData> ballCountAsObserable = new BehaviorSubject<BallFallAmountOutputData>(new BallFallAmountOutputData() { amountText = "Fall Ball: 0" });
    public void BallCount(BallFallDetectInputData stateData)
    {
        if (stateData.HallType == HallType.Other) return;
        if (stateData.FallDetectLayerName == "Ball")
        {
            fallCounterEntity.Amount++;
        }
        Output();
    }
    private void Output()
    {
        BallFallAmountOutputData amountData = new BallFallAmountOutputData();
        amountData.amountText = "Fall Ball: " + fallCounterEntity.Amount.ToString();
        ballCountAsObserable.OnNext(amountData);
    }

}
