using Zenject;

public class MousePositionDebugInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.BindInterfacesTo<MouseClickedController>().AsCached();
        Container.BindInterfacesTo<MousePositionDebugPresenter>().AsCached();
        Container.BindInterfacesTo<MousePositionDebugUseCase>().AsCached();
        Container.BindInterfacesTo<MouseClickedCountUseCase>().AsCached();
        Container.BindInterfacesTo<MouseClickedCountPresenter>().AsCached();
    }
}