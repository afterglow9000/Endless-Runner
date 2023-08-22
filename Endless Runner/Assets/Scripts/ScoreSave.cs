using UnityEngine;

public class ScoreSave : MonoBehaviour
{
    int highScore;
    int score;

    // Start is called before the first frame update
    void Start()
    {
        highScore = ScoreLoad.compareScore;
        score = ScoringSystem.score;
        if (score >= highScore)
        {
            PlayerPrefs.SetInt("HighScore", score);
        }
    }
}
