using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    Vector3 offset = new Vector3(15, 0, -20);
    public Transform target;

    // Update is called once per frame
    void Update()
    {
        transform.position = target.position + offset;
    }
}
