using System;

public class MousePositionDebugViewModel
{
    public MousePositionDebugViewModel(string debugText)
    {
        DebugText = debugText ?? throw new ArgumentNullException(nameof(debugText));
    }

    public string DebugText { get; }
}