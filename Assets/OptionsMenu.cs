using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsMenu : MonoBehaviour
{
    public void MainMenu ()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }

    public void LevelsMenu ()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("LevelsMenu");
    }
}
