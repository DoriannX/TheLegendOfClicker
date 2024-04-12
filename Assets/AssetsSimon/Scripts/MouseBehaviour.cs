using UnityEngine;

public class MouseBehaviour : MonoBehaviour
{
    private Spawner spawner;

    private void Start()
    {
        spawner = Spawner.instance;
    }

    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f));
        if (Input.GetMouseButtonDown(0))
        {
            if (mousePos.x < spawner.GetTarget().transform.position.x + 2 && mousePos.x > spawner.GetTarget().transform.position.x - 2 && mousePos.y < spawner.GetTarget().transform.position.y + 2 && mousePos.y > spawner.GetTarget().transform.position.y - 2)
            {
                Destroy(spawner.GetTarget());
                spawner.IncrementScore();
                GainXP.instance.GainEXP();
            }
        }
    }
}