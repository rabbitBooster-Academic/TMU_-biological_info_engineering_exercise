using System;
using UniRx;
using UnityEngine;

public class AttackRedBallUseCase : IAttackRedBallUseCase
{
    public IObservable<Vector3> AttackRedBallForceAsObservable => attackRedBallForceAsObservable;
    private Subject<Vector3> attackRedBallForceAsObservable = new Subject<Vector3>();
    private float ballForce;
    public AttackRedBallUseCase(IBallDataRepository ballDataRepository)
    {
        ballForce = ballDataRepository.GetRedBallForce();
    }

    public void AttackRedBallForce(BallAttackPositionData ballAttackPositionData)
    {
        var layerName = ballAttackPositionData.mouseDownGrabedLayer;
        if (layerName == "Ground" || layerName == "PlayerBall" || layerName == "Ball")
        {
            attackRedBallForceAsObservable.OnNext((ballAttackPositionData.MouseDownPosition - ballAttackPositionData.MouseUpPosition).normalized * ballForce);
        }
    }
}
public enum MouseState
{
    Down,
    Stay,
    Up
}
