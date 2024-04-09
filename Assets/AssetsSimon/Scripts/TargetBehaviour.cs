using UnityEngine;

public class TargetBehaviour : MonoBehaviour
{
    [SerializeField] private float timeLimit;
    private float timer;
    private Spawner spawner;

    private void Start()
    {
        spawner = Spawner.instance;
        timer = 0;
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer >= timeLimit)
        {
            Destroy(gameObject);
        }
    }
}
