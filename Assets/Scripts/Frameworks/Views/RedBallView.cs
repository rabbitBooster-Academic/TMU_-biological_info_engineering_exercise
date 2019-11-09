using UnityEngine;
using Zenject;
using UniRx;
using UniRx.Triggers;

public class RedBallView : MonoBehaviour, IPlayerBallPosition
{
    public Transform Player { get; private set; }
    [Inject]
    void Init(IAttackRedBallPresenter attackRedBallPresenter, IAttackRedBallMousePositionController attackRedBallMousePositionController)
    {
        var rigid = GetComponent<Rigidbody>();
        Player = transform;
        attackRedBallPresenter.AttackRedBallForceAsObservable.Subscribe(vm =>
        {
            rigid.AddForce(vm.Force, ForceMode.Impulse);
        });
        Vector3 mouseDownPosition = new Vector3();
        this.UpdateAsObservable().Where(_ => Input.GetMouseButtonUp(0)).Subscribe(p => attackRedBallMousePositionController.RedBallDataInput(Input.mousePosition, mouseDownPosition));
        this.UpdateAsObservable().Where(_ => Input.GetMouseButtonDown(0)).Subscribe(p => mouseDownPosition = Input.mousePosition);

    }

}

public interface IPlayerBallPosition
{
    Transform Player { get; }
}