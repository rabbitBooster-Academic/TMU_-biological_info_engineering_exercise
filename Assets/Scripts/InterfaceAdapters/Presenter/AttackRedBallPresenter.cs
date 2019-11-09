using System;
using UniRx;

public class AttackRedBallPresenter : IAttackRedBallPresenter
{
    public IObservable<AttackBallForceViewModel> AttackRedBallForceAsObservable { get; }
    public AttackRedBallPresenter(IAttackRedBallUseCase attackRedBallUseCase)
    {
        AttackRedBallForceAsObservable =  attackRedBallUseCase.AttackRedBallForceAsObservable.Select(f => new AttackBallForceViewModel(f));
    }
}
