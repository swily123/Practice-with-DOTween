using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextEditor : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private float _durationAnEffect;
    [SerializeField] private int _repeatsCount;
    [SerializeField] private LoopType _loopType;

    [Header("Text fields")]
    [SerializeField] private string _replacementText;
    [SerializeField] private string _addendumText;
    [SerializeField] private string _enumerationText;
    
    private void Start()
    {
        Sequence sequence = DOTween.Sequence();
        
        sequence.Append(_text.DOText(_replacementText, _durationAnEffect));
        sequence.Append(_text.DOText(_addendumText, _durationAnEffect).SetRelative());
        sequence.Append(_text.DOText(_enumerationText, _durationAnEffect, true, ScrambleMode.All));
        sequence.SetLoops(_repeatsCount, _loopType);
    }
}