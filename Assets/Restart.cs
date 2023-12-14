using UnityEngine;
using UnityEngine.SceneManagement;


public class Restart : MonoBehaviour
{
    public void Replay()
    {
        SceneManager.LoadScene("Galaan");
        Time.timeScale = 1;
    }
}
