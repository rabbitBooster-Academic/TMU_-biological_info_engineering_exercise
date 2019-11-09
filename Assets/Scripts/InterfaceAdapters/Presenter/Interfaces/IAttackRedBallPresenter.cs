using System;

public interface IAttackRedBallPresenter
{
    IObservable<AttackBallForceViewModel> AttackRedBallForceAsObservable { get; }
}