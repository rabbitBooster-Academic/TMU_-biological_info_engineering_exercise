using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class ElapsedTimeUseCase
{
    public ElapsedTimeUseCase(ITimeDataTransferController timeDataTransferController, IElapsedTimeViewerPresenter elapsedTimeViewerPresenter)
    {
        float ElaspedTime = 0f;
        timeDataTransferController.DeltaTimeAsObservable.Select(f =>
        {
            ElaspedTime += f;
            return ElaspedTime;
        }).Select(f =>
        {
            return "Time: " + ElaspedTime;
        }).Subscribe(elapsedTimeViewerPresenter.ElapsedTimeInput);
    }
}
public interface ITimeDataTransferController
{
    IObservable<float> DeltaTimeAsObservable { get; }
}
public interface IElapsedTimeViewerPresenter
{
    void ElapsedTimeInput(string elaspedstring);
}
public class MousePositionPointerUseCase
{

}
public interface IMousePositionController
{

}
public class PointerPositionDataStructure
{
    public bool isMouseDown { get; }
    public Vector3 MousePosition { get; }
    public Vector3 MouseDownPosition { get; }
    public Vector3 MouseUpPosition { get; }
}