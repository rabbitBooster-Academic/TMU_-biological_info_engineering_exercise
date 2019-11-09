using UnityEngine;
using Zenject;
using UniRx.Triggers;
using UniRx;

public class BallFallDetectView : MonoBehaviour
{
    [SerializeField] HallType hallType = HallType.Hall;
    IBallFallDetectController ballFallDetectController;
    [Inject]
    private void Init(IBallFallDetectController ballFallDetectController)
    {
        this.ballFallDetectController = ballFallDetectController;
    }
    private void Start()
    {
        this.OnTriggerEnterAsObservable().Select(c => (c.gameObject.layer, hallType.ToString())).Subscribe(ballFallDetectController.BallTriggerEnterAsOvserver);
    }
}
enum HallType
{
    Hall,
    Other
}
