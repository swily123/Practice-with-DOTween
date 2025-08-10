using DG.Tweening;
using UnityEngine;

public class Sizer : MonoBehaviour
{
    [SerializeField] private float _direction;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeatsCount;
    [SerializeField] private LoopType _loopType;

    private void Start()
    {
        transform.DOScale(_direction, _duration).SetLoops(_repeatsCount, _loopType);
    }
}