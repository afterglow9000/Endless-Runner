using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class ScoreLoad : MonoBehaviour
{
    string scoreLoad;

    public GameObject highScoreDisplay;

    public static int compareScore;

    // Start is called before the first frame update
    void Start()
    {
        StreamReader streamReader = new StreamReader("HighScore.txt");

        string line = streamReader.ReadLine();

        while (line != null)
        {
            scoreLoad = line;
            line = streamReader.ReadLine();
        }

        streamReader.Close();

        highScoreDisplay.GetComponent<Text>().text = scoreLoad.ToString();

        compareScore = int.Parse(scoreLoad);
    }
}
