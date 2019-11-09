using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IBallFallAmountPresenter
{
    IObservable<BallFallAmountViewModel> viewModelAsObserable { get; }
}
