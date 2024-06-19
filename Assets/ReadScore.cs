using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ReadScore : MonoBehaviour
{
    public TMP_Text highScoreText;

    // Start is called before the first frame update
    void Start()
    {
        int score = GameObject.Find("ScoreManager").GetComponent<ScoreManager>().Score;
        GetComponent<TMP_Text>().SetText(score.ToString());

        // Dapatkan high score dari PlayerPrefs
        int highScore = PlayerPrefs.GetInt("HighScore", 0);

        // Simpan high score jika score saat ini lebih tinggi
        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("HighScore", highScore);
            PlayerPrefs.Save();
        }

        // Tampilkan high score
        if (highScoreText != null)
        {
            highScoreText.SetText("High Score: " + highScore.ToString());
        }
    }
}
