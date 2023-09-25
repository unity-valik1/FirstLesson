using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;
using UnityEngine.UIElements;

public class DotWeenPingPong : MonoBehaviour
{
    [SerializeField] Vector3 moveDistance;
    [SerializeField] float moveTime = 2f;

    void Start()
    {
        transform.DOMove(moveDistance, moveTime)
            .SetRelative(true)
            .SetEase(Ease.Linear)
            .SetLoops(-1, LoopType.Yoyo);
    }
}
