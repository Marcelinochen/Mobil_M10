using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dead_car : MonoBehaviour
{
    public AudioSource crashSound;

    void Start()
    {

    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        crashSound.Play();
        Destroy(gameObject);
        GameObject.Find("ScoreManager").GetComponent<ScoreManager>().GameOver();
    }

    void Update()
    {
    
    }
}
