using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public int scoreValue = 0;

    public static Score instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        UpdateScoreText();
    }

    private void Update()
    {
        UpdateScoreText();
    }

    public void AddScore(int points)
    {
        scoreValue += points;
        UpdateScoreText();
    }

    public void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + scoreValue.ToString();
        }
    }
}
