using System;
using UniRx;

public class GameOverSpawnPresenter : IGameOverSpawnPresenter
{
    public IObservable<GameOverDetectViewModel> GameOverAsObserable { get; }
    public GameOverSpawnPresenter(IGameOverDetectUseCase gameOverDetectUseCase)
    {
        GameOverAsObserable = gameOverDetectUseCase.GameOverAsObserable.Select(_ => new GameOverDetectViewModel());
    }
}
public class ElaspeTimeViewPresenter : IElapsedTimeViewerPresenter
{
    private readonly IElaspeTimeView elaspeTimeView;

    public ElaspeTimeViewPresenter(IElaspeTimeView elaspeTimeView)
    {
        this.elaspeTimeView = elaspeTimeView;
    }

    public void ElapsedTimeInput(string elaspedstring)
    {
        elaspeTimeView.SetText(new ElaspeTimeViewModel(elaspedstring));
    }
}
public interface IElaspeTimeView
{
    void SetText(ElaspeTimeViewModel viewmodel);
}
public struct ElaspeTimeViewModel
{
    public string text { get; }

    public ElaspeTimeViewModel(string text)
    {
        this.text = text ?? throw new ArgumentNullException(nameof(text));
    }
}