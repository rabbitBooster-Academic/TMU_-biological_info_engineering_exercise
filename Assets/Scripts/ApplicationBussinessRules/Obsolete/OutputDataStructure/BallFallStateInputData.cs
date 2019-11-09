using System;

public class BallFallDetectInputData
{
    public string FallDetectLayerName = "";
    public HallType HallType;

    public BallFallDetectInputData(string fallDetectLayerName, HallType hallType)
    {
        this.FallDetectLayerName = fallDetectLayerName ?? throw new ArgumentNullException(nameof(fallDetectLayerName));
        HallType = hallType;
    }
}
public enum HallType
{
    Hall,
    Other
}
