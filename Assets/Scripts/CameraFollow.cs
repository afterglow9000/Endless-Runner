using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Public
    public Transform target;

    private void LateUpdate()
    {
        Vector3 position1 = transform.position;
        position1.y = 0;
        transform.position = new Vector3(position1.x, position1.y, position1.z);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position1 = target.transform.position;
        position1.x += 10;
        position1.z -= 16;
        transform.position = new Vector3(position1.x, position1.y, position1.z);
    }
}
