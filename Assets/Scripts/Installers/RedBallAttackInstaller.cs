using UnityEngine;
using Zenject;

public class RedBallAttackInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.BindInterfacesTo<AttackRedBallMousePositionController>().AsCached();
        Container.BindInterfacesTo<AttackRedBallPresenter>().AsCached();
        Container.BindInterfacesTo<AttackRedBallUseCase>().AsCached();
        Container.BindInterfacesTo<BallDataRepository>().AsCached();
    }
}
