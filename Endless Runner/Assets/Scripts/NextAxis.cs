using UnityEngine;

public class NextAxis : MonoBehaviour
{
    // Private
    float internalAxis;

    // Public
    public static float xAxis = 50f;

    // Update is called once per frame
    void Update()
    {
        internalAxis = xAxis;
    }
}
