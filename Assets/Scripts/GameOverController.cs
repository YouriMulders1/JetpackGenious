using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene("StartGame"); 
    }
}
