using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseManager : MonoBehaviour
{
    public float time;

    private void Start()
    {
        time = Time.deltaTime;
    }

    private void Update()
    {
        time += Time.deltaTime;
        OnLose();
    }

    public void OnLose()
    {
        if (time > 10)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
