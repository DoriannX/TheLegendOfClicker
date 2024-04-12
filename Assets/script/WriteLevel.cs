using TMPro;
using UnityEngine;

public class WriteLevel : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI LevelText;

    private void Start()
    {
        LevelText.text = "Level : ";
    }
}
