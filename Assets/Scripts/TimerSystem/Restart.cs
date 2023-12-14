using UnityEngine;
using UnityEngine.SceneManagement;


public class Restart : MonoBehaviour
{
    public void Replay1()
    {
        SceneManager.LoadScene("Scene final");
        Time.timeScale = 1;
    }

    public void Replay2()
    {
        SceneManager.LoadScene("Galaan");
        Time.timeScale = 1;
    }
}
