using DG.Tweening;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private Vector3 _direction;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeatsCount;
    [SerializeField] private LoopType _loopType;

    private void Start()
    {
        transform.DORotate(_direction, _duration).SetLoops(_repeatsCount, _loopType);
    }
}