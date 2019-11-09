using System;
using UnityEngine;

public interface IAttackRedBallUseCase
{
    IObservable<Vector3> AttackRedBallForceAsObservable { get; }

    void AttackRedBallForce(BallAttackPositionData ballAttackPositionData);
}