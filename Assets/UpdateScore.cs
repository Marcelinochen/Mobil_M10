using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UpdateScoreText : MonoBehaviour
{
    public TMP_Text scoreText;
    private ScoreManager scoreManager;

    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    void Update()
    {
        scoreText.SetText(scoreManager.Score.ToString());
    }
}
