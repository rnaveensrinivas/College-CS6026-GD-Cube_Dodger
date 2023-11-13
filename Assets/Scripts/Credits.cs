using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void Replay()
    {
        Debug.Log("Replay");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
}
