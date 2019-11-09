
using System;
using UniRx;

public class GameOverDetectUseCase : IGameOverDetectUseCase
{
    public IObservable<Unit> GameOverAsObserable => gameOverAsObserable;
    public Subject<Unit> gameOverAsObserable = new Subject<Unit>();
    public void GameOverDetect(BallFallDetectInputData stateData)
    {
        if (stateData.FallDetectLayerName == "PlayerBall")
        {
            gameOverAsObserable.OnNext(Unit.Default);
        }
    }
}