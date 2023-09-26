using UnityEngine;
using DG.Tweening;

public class TransformTo : MonoBehaviour
{
    [SerializeField] private Vector3[] _wayPoints;

    void Start()
    {
        Sequence  sequence = DOTween.Sequence();

        sequence.Append(transform.DOPath(_wayPoints, 5, PathType.Linear).SetEase(Ease.Linear).SetOptions(true).SetLookAt(0.01f));

        sequence.SetLoops(-1);
    }
}
