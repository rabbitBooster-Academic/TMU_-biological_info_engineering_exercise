using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class BallCountInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.BindInterfacesTo<BallFallAmountPresenter>().AsCached();
        Container.BindInterfacesTo<BallFallDetectController>().AsCached();

        Container.BindInterfacesTo<GameOverDetectUseCase>().AsCached();
        Container.BindInterfacesTo<GameOverSpawnPresenter>().AsCached();

        Container.BindInterfacesTo<FallBallCountUseCase>().AsCached();
    }
}
