using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject deathBlack;
    public GameObject gameOver;
    public GameObject uFO;

    private void OnTriggerEnter(Collider collider)
    {
        deathBlack.SetActive(true);
        gameOver.SetActive(true);
        uFO.SetActive(false);
    }
}
