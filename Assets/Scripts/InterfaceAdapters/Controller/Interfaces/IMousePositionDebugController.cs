using UnityEngine;

public interface IMouseClickedController
{
    void MouseDownInput(Vector3 mousePosition);
    void MouseStayInput(Vector3 mousePosition);
    void MouseUpInput(Vector3 mousePosition);
}