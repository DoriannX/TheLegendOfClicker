using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    Fade_In_Out _fade;
    private bool _isWin = true;


    private void Start()
    {
        _fade = FindObjectOfType<Fade_In_Out>();
    }

    private IEnumerator ChangeSceneWin()
    {
        if (_isWin)
        {
            TransitionManager.Instance.GetComponent<Fade_In_Out>().FadeIn();

            yield return new WaitForSeconds(2);
            TransitionManager.Instance.GetComponent<Fade_In_Out>().FadeOut();
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
    private IEnumerator ChangeSceneLose()
    {
        if (!_isWin)
        {
            TransitionManager.Instance.GetComponent<Fade_In_Out>().FadeIn();

            yield return new WaitForSeconds(2);
            TransitionManager.Instance.GetComponent<Fade_In_Out>().FadeOut();
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }
}
