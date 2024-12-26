using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int playerScore;
    public Text scoreText;
    public Text highestScoreText;
    public GameObject gameOverScreen; 
    private int highestScore;

    void Awake()
    {
        highestScore = PlayerPrefs.GetInt("HighScore", 0);
        highestScoreText.text = $"Highest Score: {highestScore}";
    }

    void Update()
    {
        if (playerScore > 10)
        {
            PipeMoveScript.moveSpeed = 6;
        }
    }

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    { 
        playerScore+= scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame()
    { 
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver() {

        if (playerScore > highestScore)
        {
            PlayerPrefs.SetInt("HighScore",playerScore);
        }
        gameOverScreen.SetActive(true);
    }
}
