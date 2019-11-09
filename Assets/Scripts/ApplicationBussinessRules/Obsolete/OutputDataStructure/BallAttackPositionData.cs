using System;
using UnityEngine;

public class BallAttackPositionData
{
    public Vector3 MouseDownPosition;
    public Vector3 MouseUpPosition;
    public string mouseDownGrabedLayer;

    public BallAttackPositionData(Vector3 mouseDownPosition, Vector3 mouseUpPosition, string mouseDownGrabedLayer)
    {
        MouseDownPosition = mouseDownPosition;
        MouseUpPosition = mouseUpPosition;
        this.mouseDownGrabedLayer = mouseDownGrabedLayer ?? throw new ArgumentNullException(nameof(mouseDownGrabedLayer));
    }
}