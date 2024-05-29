using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    bool ended = false;
    public int Score { get; private set; }
    // Start is called before the first frame update
    void Start(){
        Score = 0;
        ended = false;
        DontDestroyOnLoad(gameObject);
    }

    public void Boost(){
        if (!ended){
            Score += 100;
        }
    }

    public void GameOver(){
        SceneManager.LoadScene("GameOver");
        ended = true;
    }
}
