using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameObject playButton;
    public GameObject gameOverPanel;
    public TextMeshProUGUI scoreText;

    private bool isGameOver = false;
    private bool isGameStarted = false;
    private float score = 0f;

    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);

        if (gameOverPanel != null)
            gameOverPanel.SetActive(false);
    }

    void Update()
    {
        if (isGameStarted && !isGameOver)
        {
            score += Time.deltaTime;
            scoreText.text = "Score: " + Mathf.FloorToInt(score).ToString();
        }
    }

    public void StartGame()
    {
        isGameStarted = true;
        playButton.SetActive(false);
    }

    public void GameOver()
    {
        if (!isGameOver)
        {
            isGameOver = true;
            gameOverPanel.SetActive(true);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public bool IsGameOver => isGameOver;
    public bool IsGameStarted => isGameStarted;
}
