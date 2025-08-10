using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextEditor : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private float _durationAnEffect;

    [Header("Text fields")]
    [SerializeField] private string _replacementText;
    [SerializeField] private string _addendumText;
    [SerializeField] private string _enumerationText;
    
    private void Start()
    {
        List<Tween> tweens = new List<Tween>()
        {
            _text.DOText(_replacementText, _durationAnEffect), _text.DOText(_addendumText, _durationAnEffect).SetRelative(),
            _text.DOText(_enumerationText, _durationAnEffect, true, ScrambleMode.All)
        };

        for (int i = 0; i < tweens.Count; i++)
        {
            tweens[i].SetDelay(_durationAnEffect * i);
        }
    }
}