using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using DG.Tweening;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private float _duration;

    private Coroutine _coroutine;

    private void Start()
    {
        StartCoroutine(HandleText());
    }

    private IEnumerator HandleText()
    {
        WaitForSeconds waitTime = new WaitForSeconds(_duration);

        while (enabled)
        {
            StartCoroutine(ChangeText());

            yield return waitTime;
        }
    }

    private IEnumerator ChangeText()
    {
        if (_coroutine == null)
        {
            _text.DOText("Changed", _duration);

            yield return new WaitForSeconds(_duration);

            _coroutine = StartCoroutine(ModificateText());
        }
    }

    private IEnumerator ModificateText()
    {
        _text.DOText("Added", _duration).SetRelative();

        yield return new WaitForSeconds(_duration);

        StartCoroutine(HackText());
    }

    private IEnumerator HackText()
    {
        _text.DOText("Hacked", _duration, true, ScrambleMode.All);

        yield return new WaitForSeconds(_duration);

        _coroutine = null;
    }
}