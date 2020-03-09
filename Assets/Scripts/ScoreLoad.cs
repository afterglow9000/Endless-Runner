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
        scoreLoad = PlayerPrefs.GetString("HighScore");

        highScoreDisplay.GetComponent<Text>().text = scoreLoad.ToString();

        compareScore = int.Parse(scoreLoad);
    }
}
