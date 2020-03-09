using UnityEngine;

public class StarRotation : MonoBehaviour
{
    int speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speed = 2;
        transform.Rotate(0, speed, 0, Space.World);
    }
}
