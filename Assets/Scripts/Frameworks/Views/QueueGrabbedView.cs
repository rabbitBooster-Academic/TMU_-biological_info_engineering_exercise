using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueueGrabbedView : MonoBehaviour
{
    private void OnMouseDrag()
    {
        var x = Input.mousePosition;
        x.z = 1f;
        transform.parent.position = Camera.main.ScreenToWorldPoint(x);
    }
}
