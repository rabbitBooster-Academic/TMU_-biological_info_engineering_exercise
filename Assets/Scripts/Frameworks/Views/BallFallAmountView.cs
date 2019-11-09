using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Zenject;
using UniRx;

public class BallFallAmountView : MonoBehaviour
{
    Text text;
    [Inject]
    public void Init(IBallFallAmountPresenter fallAmountPresenter)
    {
        text = GetComponent<Text>();
        fallAmountPresenter.viewModelAsObserable.Subscribe(t => text.text = t.AmountText);
    }

}
