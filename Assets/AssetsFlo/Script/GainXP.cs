using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;



public class GainXP : MonoBehaviour
{

    //private int _currentLevel;


    private int _level = 1;
    private int _currentXP;


    [SerializeField] private int _requireXP;
    [SerializeField] private int _gainXP;

   [SerializeField] private TextMeshProUGUI _lvl;
   [SerializeField] private TextMeshProUGUI _exp;


    public static GainXP instance;
    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        DontDestroyOnLoad(gameObject);

        UpdateText();
    }

    public void GainEXP()
    {
        _currentXP += _gainXP + SceneManager.GetActiveScene().buildIndex;
        if (_currentXP >= _requireXP)
        {
            LevelUP();
        }
        UpdateText();

    }

    public void LevelUP()
    {
        _level++;
        _requireXP = _requireXP + 20;
        _gainXP = _gainXP + 2;
        _currentXP = 0;
        
    }

    private void UpdateText()
    {
        _exp.text = ("XP: " + _currentXP.ToString() + "/" + _requireXP.ToString());
        _lvl.text = ("Level: " + _level.ToString());
    }

}
