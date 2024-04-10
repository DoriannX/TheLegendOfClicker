using UnityEngine;

public class Fade_In_Out : MonoBehaviour
{
    [SerializeField] private CanvasGroup _canvasGroup;

    [SerializeField] private bool _fadeOut = false;
    [SerializeField] private bool _fadeIn = false;

    [SerializeField] private float _timeToFade;

    void Update()
    {
        if (_fadeIn == true)
        {
            if (_canvasGroup.alpha < 1)
            {
                _canvasGroup.alpha += _timeToFade * Time.deltaTime;
                if (_canvasGroup.alpha >= 1)
                {
                    _fadeIn = false;
                }
            }
        }
        if (_fadeOut == true)
        {
            if (_canvasGroup.alpha >= 0)
            {
                _canvasGroup.alpha -= _timeToFade * Time.deltaTime;
                if (_canvasGroup.alpha == 0)
                {
                    _fadeOut = false;
                }
            }
        }
    }

    public void FadeIn()
    {
        _fadeIn = true;
    }

    public void FadeOut()
    {
        _fadeOut = true;
    }
}
