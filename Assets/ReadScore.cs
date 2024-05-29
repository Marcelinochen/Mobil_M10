using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ReadScore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int score = GameObject.Find("ScoreManager").GetComponent<ScoreManager>().Score;
        GetComponent<TMP_Text>().SetText(score.ToString());
    }
}
