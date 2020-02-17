using UnityEngine;

public class StarPickup : MonoBehaviour
{
    public int starScore = 500;
    public AudioSource starSound;

    private void OnTriggerEnter(Collider collider)
    {
        starSound.Play();
        ScoringSystem.score += starScore;
        this.transform.position = new Vector3(0, 1000, 0);
    }
}
