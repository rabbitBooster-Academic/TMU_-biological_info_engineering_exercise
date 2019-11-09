using System;
using UniRx;
using UnityEngine;

public class MousePositionDebugUseCase : IDebugMousePositionUseCase
{
    public IObservable<string> DebugMousePositionAsObservable => debugMousePositionAsObservable;
    private Subject<string> debugMousePositionAsObservable = new Subject<string>();
    public void MousePositionInput(Vector3 mousePosition, MouseState state)
    {
        switch (state)
        {
            case MouseState.Down:
                debugMousePositionAsObservable.OnNext("MouseDownPosition : " + mousePosition.ToString());
                break;
            case MouseState.Stay:
                debugMousePositionAsObservable.OnNext("MouseStayPosition : " + mousePosition.ToString());
                break;
            case MouseState.Up:
                debugMousePositionAsObservable.OnNext("MouseUpPosition : " + mousePosition.ToString());
                break;
            default:
                break;
        }

    }
}
