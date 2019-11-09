
using System;
using UniRx;

public interface IGameOverDetectUseCase
{
    IObservable<Unit> GameOverAsObserable { get; }
    void GameOverDetect(BallFallDetectInputData stateData);
}