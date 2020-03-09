using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{
    public static int score;
    public GameObject scoreDisplay;

    void AddScore()
    {
        score += 5;
        scoreDisplay.GetComponent<Text>().text = "Score: " + score;
    }

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        InvokeRepeating("AddScore", 1, 0.1f);
    }
}
