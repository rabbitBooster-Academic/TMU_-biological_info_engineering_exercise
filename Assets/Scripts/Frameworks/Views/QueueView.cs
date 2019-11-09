using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class QueueView : MonoBehaviour
{
    Transform pos;
    [Inject]void Init(IPlayerBallPosition ballPosition)
    {
        pos = ballPosition.Player;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(pos.position, Vector3.back);
    }

}
