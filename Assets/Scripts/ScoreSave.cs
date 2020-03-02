using System.IO;
using UnityEngine;

public class ScoreSave : MonoBehaviour
{
    string path = "HighScore.txt";
    int score;

    // Start is called before the first frame update
    void Start()
    {
        score = ScoringSystem.score;
        StreamWriter ourFile = File.CreateText(path);
        ourFile.WriteLine("" + score);
        ourFile.Close();
    }
}
