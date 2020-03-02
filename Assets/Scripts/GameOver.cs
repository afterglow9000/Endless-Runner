using UnityEngine;

public class GameOver : MonoBehaviour
{
    public AudioSource crash;
    public GameObject deathBlack;
    public GameObject gameOver;
    public GameObject highScore;
    public GameObject mainAudio;
    public GameObject uFO;

    private void OnTriggerEnter(Collider collider)
    {
        highScore.SetActive(true);
        crash.Play();
        mainAudio.SetActive(false);
        deathBlack.SetActive(true);
        gameOver.SetActive(true);
        uFO.SetActive(false);
    }
}
