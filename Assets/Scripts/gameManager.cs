using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    bool gameHasEnded = false; 
    public float restartDelay = 1f;
    public GameObject compeleteLevelUI;
    public GameObject QuitGame; 
    public float slowness = 10f;

    public void CompleteLevel(){
        QuitGame.SetActive(false);
        compeleteLevelUI.SetActive(true);
    }

    public void EndGame()
    {
        if( gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");

            StartCoroutine(waiter());
        }
    }

    IEnumerator waiter()
    {
        Time.timeScale = 1f / slowness;
        Time.fixedDeltaTime = Time.fixedDeltaTime / slowness;

        yield return new WaitForSeconds(1/slowness);

        QuitGame.SetActive(false);
        compeleteLevelUI.SetActive(true);

        Time.timeScale = 1f;
        Time.fixedDeltaTime = Time.fixedDeltaTime * slowness;
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
