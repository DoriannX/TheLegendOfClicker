using UnityEngine;
using UnityEngine.SceneManagement;



public class GainXP : MonoBehaviour
{

    //private int _currentLevel;


    private int _level = 1;
    private int _currentXP;


    [SerializeField] private int _requireXP;
    [SerializeField] private int _gainXP;


    public static GainXP instance;
    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        DontDestroyOnLoad(gameObject);
    }

    public void GainEXP()
    {
        _currentXP += _gainXP + SceneManager.GetActiveScene().buildIndex;
        if (_currentXP >= _requireXP)
            LevelUP();
    }

    public void LevelUP()
    {
        _level++;
        _requireXP = _requireXP + 20;
        _gainXP = _gainXP + 2;
        _currentXP = 0;
    }
}
