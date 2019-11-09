using System;

public interface IMouseClickedCountPresenter
{
    IObservable<MouseClicedCountDataViewModel> mousePositionDebugTextAsObservable { get; }
}