using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayOrQuit : MonoBehaviour
{
    void OnGUI()
    {
        float height1 = Screen.height / 2 + 100;
        float width1 = Screen.width / 2 - 50;

        Rect rectangle1 = new Rect(width1, height1, 100, 30);

        if (GUI.Button(rectangle1, "Play Again"))
        {
            SceneManager.LoadScene(2);
        }

        float height2 = Screen.height / 2 + 150;
        float width2 = Screen.width / 2 - 50;

        Rect rectangle2 = new Rect(width2, height2, 100, 30);

        if (GUI.Button(rectangle2, "Main Menu"))
        {
            SceneManager.LoadScene(0);
        }
    }
}
