using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void OnPlayButton()
    {
        SceneManager.LoadScene("Scenes/Gameplay/World");
    }

    public void OnAboutButton()
    {
        SceneManager.LoadScene("Scenes/UI/About");
    }

    public void OnCreditsButton()
    {
        SceneManager.LoadScene("Scenes/UI/Credits");
    }

    public void OnQuitButton()
    {
        Application.Quit();
    }
}
