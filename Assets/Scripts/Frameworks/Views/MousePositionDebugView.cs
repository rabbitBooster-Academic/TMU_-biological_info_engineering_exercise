using UniRx;
using UniRx.Triggers;
using UnityEngine;
using Zenject;

public class MousePositionDebugView : MonoBehaviour
{
    [Inject] 
    private void Initialize(IMouseClickedController mousePositionDebugController, IMousePositionDebugPresenter mousePositionDebugPresenter)
    {
        this.UpdateAsObservable().Where(_ => Input.GetMouseButtonUp(0)).Subscribe(p => mousePositionDebugController.MouseUpInput(Input.mousePosition));
        this.UpdateAsObservable().Where(_ => Input.GetMouseButtonDown(0)).Subscribe(p => mousePositionDebugController.MouseDownInput(Input.mousePosition));

        mousePositionDebugPresenter.mousePositionDebugTextAsObservable.Select(vm => vm.DebugText).Subscribe(Debug.Log);
    }
}
