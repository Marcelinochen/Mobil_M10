using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    bool ended = false;
    public int Score { get; private set; }
    private int highScore;

    private UpdateScoreText updateScoreText;
    // Start is called before the first frame update
    void Start(){
        Score = 0;
        ended = false;
        highScore = PlayerPrefs.GetInt("HighScore", 0);
        DontDestroyOnLoad(gameObject);

        updateScoreText = GameObject.Find("ScoreText").GetComponent<UpdateScoreText>();
    }

    public void Boost(){
        if (!ended){
            Score += 100;
        }
    }

    public void GameOver(){
        if (Score > highScore)
        {
            highScore = Score;
            // Simpan highscore ke PlayerPrefs
            PlayerPrefs.SetInt("HighScore", highScore);
            PlayerPrefs.Save();
        }
        SceneManager.LoadScene("GameOver");
        ended = true;
    }
}
