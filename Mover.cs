using UnityEngine;
using DG.Tweening;

public class Mover : MonoBehaviour
{
    [SerializeField] private Vector3 _offset;
    [SerializeField] private float _duration;
    [SerializeField] private int _reapets;
    [SerializeField] private LoopType _loopType;

    private void Start()
    {
        transform.DOMove(transform.position + _offset, _duration).SetLoops(_reapets, _loopType);
    }
}
