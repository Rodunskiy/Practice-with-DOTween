using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class TextTo : MonoBehaviour
{
    [SerializeField] private Text _text1;
    [SerializeField] private Text _text2;
    [SerializeField] private Text _text3;

    private void Start()
    {
        _text1.DOText("Я заменил этот текст", 3);
        _text2.DOText("Это дополнение текста", 3).SetRelative();
        _text3.DOText("Я взломал этот текст", 3,true, ScrambleMode.All);
    }
}
