using UnityEngine;

public class GuardDetection : MonoBehaviour
{
    public string playerTag = "Player";
    public GameObject gameOverScreen;
    public AudioSource gameOverSound;
    public AudioSource backgroundMusic;
    public GameManager gameManager; // Reference to GameManager

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(playerTag))
        {
            Debug.Log("Player Caught!");
            ShowGameOverScreen();
        }
    }

    private void ShowGameOverScreen()
    {
        if (gameOverScreen != null)
        {
            gameOverScreen.SetActive(true);
            Time.timeScale = 0;
        }

        if (gameOverSound != null)
        {
            gameOverSound.Play();
        }

        if (backgroundMusic != null)
        {
            backgroundMusic.Pause();
        }
    }

    public void TriggerRestart()
    {
        if (gameManager != null)
        {
            gameManager.RestartGame();
        }
    }
}
