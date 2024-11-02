using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] Interface _interface;
    public static GameManager _instance;
    int _currentScore;
    public int getSetScore
    {
        get
        {
            return _currentScore;
        }
        set
        {
            _currentScore = value;
            if (_currentScore <= 0)
            {
                _currentScore = 0;
            }
            _interface.ScoreText(_currentScore);

        }
    }
    // Start is called before the first frame update
    void Start()
    {
        getSetScore = getSetScore + 2;      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Awake()
    {
        if(_instance)
        {
            Destroy(gameObject);
        }
        _instance = this;
    }
}
