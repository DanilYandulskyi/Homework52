using UnityEngine;
using DG.Tweening;

public class Scaler : MonoBehaviour
{
    [SerializeField] private Vector3 _finalScale;
    [SerializeField] private float _duration;

    private void Update()
    {
        if (transform.localScale == _finalScale)
        {
            transform.DOScale(Vector3.one, _duration);
        }        
        else if (transform.localScale == Vector3.one)
        {
            transform.DOScale(_finalScale, _duration);
        }
    }
}
