using UnityEngine;
using DG.Tweening;

public class ScaleTo : MonoBehaviour
{ 
    private void Start()
    {
        transform.DOScale(new Vector3(4, 4, 4), 3).SetEase(Ease.Linear).SetLoops(-1,LoopType.Yoyo);
    }
}
