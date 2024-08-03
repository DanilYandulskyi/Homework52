using UnityEngine;
using DG.Tweening;
using System.Collections;

public class Rotater : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private float _xRotation;

    private void Start()
    {
        StartCoroutine(Rotate());
    }

    private IEnumerator Rotate()
    {
        WaitForSeconds waitTime = new WaitForSeconds(_duration);

        while (enabled)
        {
            transform.DORotate(new Vector3(_xRotation, 0, 0), _duration);

            _xRotation += 180;
         
            yield return waitTime;
        }
    }
}
