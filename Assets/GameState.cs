using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameState : MonoBehaviour
{
    public bool isGameOver = false;
    int _goalsHit = 0;
    int _score = 0;
    [SerializeField] GameObject _scoreText;
    [SerializeField] GameObject _gameOverText;
    [SerializeField] GameObject _winText;
    [SerializeField] GameObject _nextLevelButton;
    [SerializeField] GameObject _optionsMenu;

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
            _winText.SetActive(true);
            _nextLevelButton.SetActive(true);
        }
        OptionsMenu();
    }

    public void InitiateGameOver()
    {
        isGameOver = true;
        _gameOverText.SetActive(true);
    }

    public void IncrementGoalsHit()
    {
        _goalsHit += 1;
    }

    public void GemCollected()
    {
        _score += 10;
        _scoreText.GetComponent<Text>().text = "Score: " + _score;
    }

    public void OptionsMenu()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(_optionsMenu.activeSelf == true)
            {
                Time.timeScale = 1;
                _optionsMenu.SetActive(false);
            } else
            {
                Time.timeScale = 0;
                _optionsMenu.SetActive(true);
            }
        }
    }
}
