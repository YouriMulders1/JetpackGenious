using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuController : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("JetPackGenious"); // Vervang "GameScene" met de naam van jouw gamescene
    }
}
