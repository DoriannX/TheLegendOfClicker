using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject target;
    [SerializeField] private int quota;
    [SerializeField] private float timer;
    [SerializeField] private TextMeshProUGUI timeDisplay;
    [SerializeField] private TextMeshProUGUI scoreDisplay;
    private int score;
    private bool isTargetHere;
    private GameObject newTarget;
    public static Spawner instance;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        isTargetHere = false;
    }

    private void Update()
    {
        timer -= Time.deltaTime;
        if (!isTargetHere)
        {
            SpawnTarget();
        }
        else if (newTarget.IsUnityNull())
        {
            isTargetHere = false;
        }
        CheckForWinOrLose();
        timeDisplay.text = "Time : " + timer.ConvertTo<int>();
        scoreDisplay.text = "Score : " + score + "/" + quota;
    }

    private void CheckForWinOrLose()
    {
        if (score >= quota)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else if (timer <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }

    private void SpawnTarget()
    {
        Vector2 randPos = new Vector2(Random.Range(-20, 20), Random.Range(-10, 10));
        newTarget = GameObject.Instantiate(target, randPos, Quaternion.identity);
        isTargetHere = true;
    }

    public GameObject GetTarget()
    {
        return newTarget;
    }

    public void IncrementScore()
    {
        score++;
    }
}
