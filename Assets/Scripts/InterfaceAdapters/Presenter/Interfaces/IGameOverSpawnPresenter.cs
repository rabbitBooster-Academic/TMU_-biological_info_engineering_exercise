using System;

public interface IGameOverSpawnPresenter
{
    IObservable<GameOverDetectViewModel> GameOverAsObserable { get; }
}