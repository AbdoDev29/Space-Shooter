using TMPro;
using UnityEngine;


public class Score : MonoBehaviour
{
    public int currentScore;
    int highScore;
    public int totalScore;
    public TextMeshProUGUI totalScoreText;
    public TextMeshProUGUI hightScoreText;
    public TextMeshProUGUI currentScoreText;
 

    private void Start()
    {
       totalScore = PlayerPrefs.GetInt("TotalScore", 0);
       highScore = PlayerPrefs.GetInt("HighScore", 0);
    }
    // Update is called once per frame
    void Update()
    {
        currentScoreText.text = ("Score: " + currentScore);
        totalScoreText.text = ("Total Score: " + totalScore);
        PlayerPrefs.SetInt("TotalScore", totalScore);
        if (currentScore > highScore)
        {
            highScore = currentScore;
        }
        hightScoreText.text = highScore.ToString();
        PlayerPrefs.SetInt("HighScore", highScore);
    }
}
