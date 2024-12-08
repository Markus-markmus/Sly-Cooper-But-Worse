using UnityEngine;
using TMPro;

public class BottleCollector : MonoBehaviour
{
    private int BottleCount = 0;
    public int TotalBottles = 10;
    public TextMeshProUGUI BottleCountText;
    public GameObject LevelCompleteScreen;
    public GameManager gameManager; // Reference to GameManager

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Bottle")
        {
            BottleCount++;
            BottleCountText.text = ": " + BottleCount.ToString();
            Debug.Log("Bottle Count: " + BottleCount);
            Destroy(other.gameObject);

            if (BottleCount >= TotalBottles)
            {
                ShowLevelCompleteScreen();
            }
        }
    }

    private void ShowLevelCompleteScreen()
    {
        if (LevelCompleteScreen != null)
        {
            LevelCompleteScreen.SetActive(true);
            Time.timeScale = 0;
            Debug.Log("Level Complete!");
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
