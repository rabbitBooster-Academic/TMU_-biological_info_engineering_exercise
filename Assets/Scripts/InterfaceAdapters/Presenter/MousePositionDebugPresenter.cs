using System;
using UniRx;

public class MousePositionDebugPresenter : IMousePositionDebugPresenter
{
    private readonly IDebugMousePositionUseCase debugMousePositionUseCase;
    public IObservable<MousePositionDebugViewModel> mousePositionDebugTextAsObservable { get; }
    public MousePositionDebugPresenter(IDebugMousePositionUseCase debugMousePositionUseCase)
    {
        this.debugMousePositionUseCase = debugMousePositionUseCase;
        mousePositionDebugTextAsObservable = debugMousePositionUseCase.DebugMousePositionAsObservable.Select(s =>new MousePositionDebugViewModel(s));
    }
}
