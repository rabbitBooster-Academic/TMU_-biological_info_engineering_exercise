using System;

public interface IMouseClickedCountUseCase
{
    IObservable<string> DebugMousePositionAsObservable { get; }

    void MouseClicked(MouseState state);
}