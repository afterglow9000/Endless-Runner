using UnityEngine;

public class GenerateSections : MonoBehaviour
{
    // Private
    float newAxis = NextAxis.xAxis;

    GameObject newSection;

    Vector3 nextPosition = new Vector3(NextAxis.xAxis, 0, 0);

    // Public 
    public GameObject section1;
    public GameObject section2;

    private void OnTriggerEnter(Collider collider)
    {
        nextPosition = new Vector3(NextAxis.xAxis, 0, 0);

        int generator = Random.Range(1, 3);

        newAxis = NextAxis.xAxis;

        if (generator == 1)
        {
            newSection = section1;
        }
        else
        {
            newSection = section2;
        }

        Instantiate(newSection, nextPosition, Quaternion.identity);

        NextAxis.xAxis += 60;
    }
}
