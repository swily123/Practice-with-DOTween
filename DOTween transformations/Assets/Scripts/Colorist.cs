using DG.Tweening;
using UnityEngine;

public class Colorist : MonoBehaviour
{
    [SerializeField] private Material _material;
    [SerializeField] private Color _color;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeatsCount;
    [SerializeField] private LoopType _loopType;

    private void Start()
    {
        _material.color = Color.white;
        _material.DOColor(_color, _duration).SetLoops(_repeatsCount, _loopType);
    }
}