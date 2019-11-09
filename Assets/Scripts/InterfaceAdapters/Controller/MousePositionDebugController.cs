using UnityEngine;

public class MouseClickedController : IMouseClickedController
{
    private readonly IDebugMousePositionUseCase debugMousePositionUseCase;
    private readonly IMouseClickedCountUseCase mouseClickedCountUseCase;

    public MouseClickedController(IDebugMousePositionUseCase debugMousePositionUseCase, IMouseClickedCountUseCase mouseClickedCountUseCase)
    {
        this.debugMousePositionUseCase = debugMousePositionUseCase;
        this.mouseClickedCountUseCase = mouseClickedCountUseCase;
    }

    public void MouseDownInput(Vector3 mousePosition)
    {
        debugMousePositionUseCase.MousePositionInput(mousePosition, MouseState.Down);
        mouseClickedCountUseCase.MouseClicked(MouseState.Down);
    }
    public void MouseUpInput(Vector3 mousePosition)
    {
        debugMousePositionUseCase.MousePositionInput(mousePosition, MouseState.Up);
        mouseClickedCountUseCase.MouseClicked(MouseState.Up);
    }
    public void MouseStayInput(Vector3 mousePosition)
    {
        debugMousePositionUseCase.MousePositionInput(mousePosition, MouseState.Stay);
        mouseClickedCountUseCase.MouseClicked(MouseState.Stay);
    }
}
