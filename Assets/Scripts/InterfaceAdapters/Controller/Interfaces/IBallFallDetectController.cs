using System;

public interface IBallFallDetectController
{
    IObserver<(int layerId, string type)> BallTriggerEnterAsOvserver { get; }
}