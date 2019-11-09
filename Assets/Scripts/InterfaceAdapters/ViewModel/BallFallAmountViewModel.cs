using System;
using UnityEngine;

public class BallFallAmountViewModel 
{
    public BallFallAmountViewModel(string amountText)
    {
        AmountText = amountText ?? throw new ArgumentNullException(nameof(amountText));
    }

    public string AmountText { get; }
}
public class AttackBallForceViewModel
{
    public AttackBallForceViewModel(Vector3 force)
    {
        Force = force;
    }

    public Vector3 Force { get; }
}
