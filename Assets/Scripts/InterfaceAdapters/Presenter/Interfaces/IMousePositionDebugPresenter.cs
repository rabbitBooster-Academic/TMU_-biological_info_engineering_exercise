using System;

public interface IMousePositionDebugPresenter
{
    IObservable<MousePositionDebugViewModel> mousePositionDebugTextAsObservable { get; }
}