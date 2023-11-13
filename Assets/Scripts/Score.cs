using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    int score = 0; 
    int adder = 1;
    int lastseen = 0; 
    
    public int highScore = 0;

    void Start()
    {
        highScore = PlayerPrefs.GetInt("HighScore", 0); 
        
        score = 0;
        adder = 1;
        lastseen = 0;
    }

    void FixedUpdate()
    {
        if( Time.time > 0)
        {
            if(lastseen != (int)Time.time){
                Debug.Log((int)Time.time);
                lastseen = (int)Time.time; 
                score += adder; 
                if((int)Time.time % 5 == 0)
                {
                    adder += 1;
                }

            }            
        }
        PlayerPrefs.SetInt("Current_Score", (int)score);

        if((int)score > highScore){
            PlayerPrefs.SetInt("HighScore", (int)score);
        }

        scoreText.text = "HighScore: " + highScore.ToString() + "\nCurrent Score: " + score.ToString("0");

    }

    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
    
}

