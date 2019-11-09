using UniRx;
using UniRx.Triggers;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class MouseClickedCountView : MonoBehaviour
{
    [Inject]
    private void Initialize(IMouseClickedCountPresenter mouseClickedCountPresenter)
    {
        var text = GetComponent<Text>();
        mouseClickedCountPresenter.mousePositionDebugTextAsObservable.Select(vm => vm.Text).Subscribe(str =>text.text = str);
    }
}