using System;
using UniRx;

public class BallFallAmountPresenter : IBallFallAmountPresenter
{
    public IObservable<BallFallAmountViewModel> viewModelAsObserable { get; }
    public BallFallAmountPresenter(IFallBallCountUseCase fallBallCountUseCase)
    {
        viewModelAsObserable = fallBallCountUseCase.BallCountAsObserable.Select(Translate);
    }

    public BallFallAmountViewModel Translate(BallFallAmountOutputData ballFallAmountOutputData)
    {
        return new BallFallAmountViewModel(ballFallAmountOutputData.amountText);
    }
}
