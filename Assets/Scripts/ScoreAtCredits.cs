using UnityEngine;
using UnityEngine.UI;

public class ScoreAtCredits : MonoBehaviour
{
    int highscore = 0;
    int current_score = 0;
    public Text scoreAtCreditsText;

    // Start is called before the first frame update
    void Start()
    {
        highscore = PlayerPrefs.GetInt("HighScore", 0);
        Debug.Log(highscore);
        current_score = PlayerPrefs.GetInt("Current_Score", 0);
        if(current_score == highscore)
        {
            scoreAtCreditsText.text = "New Highscore!\n" + highscore.ToString();
        }
        else
        {
            scoreAtCreditsText.text = "Your Score: " + current_score.ToString() + "\nHighscore: " + highscore.ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
