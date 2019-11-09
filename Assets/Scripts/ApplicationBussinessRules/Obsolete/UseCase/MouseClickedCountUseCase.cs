using System;
using UniRx;
public class MouseClickedCountUseCase : IMouseClickedCountUseCase
{
    public IObservable<string> DebugMousePositionAsObservable => debugMousePositionAsObservable;
    private BehaviorSubject<string> debugMousePositionAsObservable = new BehaviorSubject<string>("MouseCliced : 0");
    MouseClickedCountEntity countEntity = new MouseClickedCountEntity();
    public void MouseClicked(MouseState state)
    {
        switch (state)
        {
            case MouseState.Down:
                countEntity.Amount++;
                debugMousePositionAsObservable.OnNext("MouseCliced : "+ countEntity.Amount.ToString());
                break;
            case MouseState.Stay:
                break;
            case MouseState.Up:
                break;
            default:
                break;
        }
    }
}