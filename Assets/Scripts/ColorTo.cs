using UnityEngine;
using DG.Tweening;

public class ColorTo : MonoBehaviour
{
    private Renderer _color;

    private void Start()
    {
        _color = GetComponent<Renderer>();
        _color.material.DOColor(Color.red,2).SetLoops(-1,LoopType.Yoyo);
    }
}
