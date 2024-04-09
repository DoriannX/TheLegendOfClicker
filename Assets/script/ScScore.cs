using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScScore : MonoBehaviour
{
    public int score;

    [SerializeField]private TextMeshProUGUI scoreAmount;

    public static ScScore Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    private void Start()
    {
        score = 0;
        scoreAmount.text = score.ToString() + " / 15";
    }

    private void Update()
    {
        scoreAmount.text = score.ToString()+ " / 15";
    }
}
