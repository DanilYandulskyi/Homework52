using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using System.Collections;

public class ColorChanger : MonoBehaviour
{
    [SerializeField] private RawImage _image;
    [SerializeField] private float _duration;

    private Color _color;

    private void Start()
    {
        StartCoroutine(ChangeColor());
    }

    private IEnumerator ChangeColor()
    {
        WaitForSeconds waitTime = new WaitForSeconds(_duration);

        while (enabled)
        {
            if (_color == Color.red)
            {
                _color = Color.black;
            }
            else
            {
                _color = Color.red;
            }

            _image.DOColor(_color, _duration);

            yield return waitTime;
        }
    }
}
