using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSystem : MonoBehaviour
{
    public void Quit()
    {
        Application.Quit();
    }

    public void Replay()
    {
        SceneManager.LoadScene("VR 場景");
    }
}
