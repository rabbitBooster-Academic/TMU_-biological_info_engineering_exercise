using System;
using UniRx;

public class MouseClickedCountPresenter : IMouseClickedCountPresenter
{
    private readonly IMouseClickedCountUseCase mouseClickedCountUseCase;
    public IObservable<MouseClicedCountDataViewModel> mousePositionDebugTextAsObservable { get; }
    public MouseClickedCountPresenter(IMouseClickedCountUseCase mouseClickedCountUseCase)
    {
        this.mouseClickedCountUseCase = mouseClickedCountUseCase;
        mousePositionDebugTextAsObservable = mouseClickedCountUseCase.DebugMousePositionAsObservable.Select(s => new MouseClicedCountDataViewModel(s));
    }
}
