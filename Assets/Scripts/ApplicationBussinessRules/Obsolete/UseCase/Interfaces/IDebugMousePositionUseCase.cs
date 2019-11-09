using System;
using UnityEngine;

public interface IDebugMousePositionUseCase
{
    IObservable<string> DebugMousePositionAsObservable { get; }

    void MousePositionInput(Vector3 mousePosition, MouseState state);
}