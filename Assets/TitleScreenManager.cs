using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreenManager : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void HighScores()
    {
        Debug.Log("High Scores");
    }

    public void Options()
    {
        Debug.Log("Options");
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Exit");
    }
}