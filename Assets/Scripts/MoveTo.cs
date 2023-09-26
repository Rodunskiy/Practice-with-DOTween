using UnityEngine;
using DG.Tweening;

public class MoveTo : MonoBehaviour
{
   private void Start()
    {
        transform.DOMove(new Vector3(0,5,6),2).SetEase(Ease.Linear).SetLoops(-1,LoopType.Yoyo);
    }
}
