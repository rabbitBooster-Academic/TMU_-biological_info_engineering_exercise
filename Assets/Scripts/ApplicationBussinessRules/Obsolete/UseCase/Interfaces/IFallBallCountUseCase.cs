using System;
using System.Collections.Generic;
using UniRx;

public interface IFallBallCountUseCase
{
    IObservable<BallFallAmountOutputData> BallCountAsObserable { get; }
    void BallCount(BallFallDetectInputData stateData);
}
public interface IGameoverDetectUseCase
{
    IObservable<Unit> GameOverDetectAsObserable { get; }
    void FallDetect(BallFallDetectInputData stateData);
}
