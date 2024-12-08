using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void RestartGame()
    {
        Time.timeScale = 1; // Ensure the game is unpaused
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Reload current scene
    }
}
