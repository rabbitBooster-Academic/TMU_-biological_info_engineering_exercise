using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class BallFallDetectController : IBallFallDetectController
{
    public IObserver<(int layerId, string type)> BallTriggerEnterAsOvserver => ballTriggerEnter;
    public Subject<(int layerId, string type)> ballTriggerEnter = new Subject<(int layerId, string type)>();
    private readonly IFallBallCountUseCase fallBallCountUseCase;

    public BallFallDetectController(IFallBallCountUseCase fallBallCountUseCase, IGameOverDetectUseCase gameOverDetectUseCase)
    {
        var dataOvserable = ballTriggerEnter.Select(i => new BallFallDetectInputData(LayerMask.LayerToName(i.layerId), Tlanslate(i.type)));

        dataOvserable.Subscribe(d => fallBallCountUseCase.BallCount(d));
        dataOvserable.Subscribe(d => gameOverDetectUseCase.GameOverDetect(d));
    }
    HallType Tlanslate(string hallType)
    {
        switch (hallType)
        {
            case "Hall":
                return HallType.Hall;
            case "Other":
                return HallType.Other;
            default:
                throw new InvalidOperationException();
        }
    }
}
