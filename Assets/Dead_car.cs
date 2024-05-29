using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dead_car : MonoBehaviour
{
    void Start()
    {
        
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);
        GameObject.Find("ScoreManager").GetComponent<ScoreManager>().GameOver();
    }

    void Update()
    {
    
    }
}
