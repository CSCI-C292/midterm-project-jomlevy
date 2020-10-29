using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    public bool isGameOver = false;
    int _goalsHit = 0;
    int _score = 0;

    public static GameState Instance;
    // Start is called before the first frame update
    void Awake()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if(_goalsHit == 2)
        {
            isGameOver = true;
        }
    }

    public void InitiateGameOver()
    {
        isGameOver = true;
    }

    public void IncrementGoalsHit()
    {
        _goalsHit += 1;
    }

    public void GemCollected()
    {
        _score += 10;
        Debug.Log(_score);
    }
}
