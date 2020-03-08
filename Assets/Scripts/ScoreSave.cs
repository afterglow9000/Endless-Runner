using System.IO;
using UnityEngine;

public class ScoreSave : MonoBehaviour
{
    int highScore;
    int score;

    string path = "HighScore.txt";

    // Start is called before the first frame update
    void Start()
    {
        highScore = ScoreLoad.compareScore;
        score = ScoringSystem.score;
        if (score >= highScore)
        {
            StreamWriter ourFile = File.CreateText(path);
            ourFile.WriteLine("" + score);
            ourFile.Close();
        }
    }
}
