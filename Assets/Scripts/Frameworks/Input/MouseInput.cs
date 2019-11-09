using UnityEngine;
using UniRx;
using UniRx.Triggers;
using System;
public class MouseInputView : MonoBehaviour
{
    public IObservable<Vector3> MouseUpInputAsObservable => this.OnMouseUpAsObservable().Select(_ => Input.mousePosition);
    public IObservable<Vector3> MouseDownInputAsObservable => this.OnMouseDownAsObservable().Select(_ => Input.mousePosition);
    public IObservable<Vector3> MousePosiitonAsObservable => this.UpdateAsObservable().Select(_ => Input.mousePosition);


}
