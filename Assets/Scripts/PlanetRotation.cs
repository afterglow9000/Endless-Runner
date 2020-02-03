using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    int speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speed = 1;
        transform.Rotate(0, speed, 0, Space.World);
    }
}