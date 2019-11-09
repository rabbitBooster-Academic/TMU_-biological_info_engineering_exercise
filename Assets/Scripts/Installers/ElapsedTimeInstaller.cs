using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class ElapsedTimeInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.BindInterfacesTo<DeltaTimeTransferInput>().AsCached();
        Container.BindInterfacesTo<TimeDataTransferController>().AsCached();
        Container.BindInterfacesTo<ElaspeTimeViewPresenter>().AsCached();
        Container.Bind<ElapsedTimeUseCase>().AsCached().NonLazy();
    }
}
