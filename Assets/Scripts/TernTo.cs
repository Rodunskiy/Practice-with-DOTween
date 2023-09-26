using UnityEngine;
using DG.Tweening;

public class NewBehaviourScript : MonoBehaviour
{
    private void Start()
    {
        transform.DORotate(new Vector3(50, 30, 0), 5).SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);
    }
}
