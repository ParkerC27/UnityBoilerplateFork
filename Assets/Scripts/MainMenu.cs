using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void GoToLevel()
    {
        SceneManager.LoadScene("Level1");
    }


    public void Exit()
    {
        Application.Quit();
    }
}
