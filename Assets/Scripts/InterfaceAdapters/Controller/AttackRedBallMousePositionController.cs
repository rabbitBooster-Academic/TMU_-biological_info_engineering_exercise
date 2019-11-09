using UnityEngine;

public class AttackRedBallMousePositionController : IAttackRedBallMousePositionController
{
    private readonly IAttackRedBallUseCase attackRedBallUseCase;

    public AttackRedBallMousePositionController(IAttackRedBallUseCase attackRedBallUseCase)
    {
        this.attackRedBallUseCase = attackRedBallUseCase;
    }

    public void RedBallDataInput(Vector3 mouseUpPosition, Vector3 mouseDownPosition)
    {
        var mouseUpRay = Camera.main.ScreenPointToRay(mouseUpPosition);
        var mouseDownRay = Camera.main.ScreenPointToRay(mouseDownPosition);
        if (Physics.Raycast(mouseUpRay, out var hitUp, Mathf.Infinity))
        {
            if (Physics.Raycast(mouseDownRay, out var hitDown, Mathf.Infinity))
            {
                attackRedBallUseCase.AttackRedBallForce(new BallAttackPositionData(hitDown.point, hitUp.point, LayerMask.LayerToName(hitDown.collider.gameObject.layer)));
            }
        }

    }
}
